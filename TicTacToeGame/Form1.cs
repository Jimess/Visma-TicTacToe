using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeGame.Classes;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        Square[] boxes = new Square[9];
        private int[,] wins = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 }, { 1, 5, 9 }, { 3, 5, 7 } };

        public Form1()
        {
            InitializeComponent();


            gameTimer.Interval = 1;
            gameTimer.Tick += WaitForGameOver;
            gameTimer.Start();

            StartGame();
        }

        private void StartGame()
        {
            new Stats();

            Console.WriteLine("Starting game!");

            //add click listeners
            box1.Click += new EventHandler(ButtonBoxClick);
            box2.Click += new EventHandler(ButtonBoxClick);
            box3.Click += new EventHandler(ButtonBoxClick);
            box4.Click += new EventHandler(ButtonBoxClick);
            box5.Click += new EventHandler(ButtonBoxClick);
            box6.Click += new EventHandler(ButtonBoxClick);
            box7.Click += new EventHandler(ButtonBoxClick);
            box8.Click += new EventHandler(ButtonBoxClick);
            box9.Click += new EventHandler(ButtonBoxClick);

            //add paint listeners
            box1.Paint += new PaintEventHandler(RepaindSqaure);
            box2.Paint += new PaintEventHandler(RepaindSqaure);
            box3.Paint += new PaintEventHandler(RepaindSqaure);
            box4.Paint += new PaintEventHandler(RepaindSqaure);
            box5.Paint += new PaintEventHandler(RepaindSqaure);
            box6.Paint += new PaintEventHandler(RepaindSqaure);
            box7.Paint += new PaintEventHandler(RepaindSqaure);
            box8.Paint += new PaintEventHandler(RepaindSqaure);
            box9.Paint += new PaintEventHandler(RepaindSqaure);

            //store the picboxes to list
            boxes[0] = new Square(box1, 50, 50);
            boxes[1] = new Square(box2, 50, 50);
            boxes[2] = new Square(box3, 50, 50);
            boxes[3] = new Square(box4, 50, 50);
            boxes[4] = new Square(box5, 50, 50);
            boxes[5] = new Square(box6, 50, 50);
            boxes[6] = new Square(box7, 50, 50);
            boxes[7] = new Square(box8, 50, 50);
            boxes[8] = new Square(box9, 50, 50);
            

            if (!Stats.isPlayerTurn)
                EnemyMove();
        }

        private void ResetGame()
        {
            new Stats();

            Console.WriteLine("Restarting game!");
            foreach (Square sq in boxes)
            {
                sq.Clear();
                sq.box.Invalidate();
            }
        }

        private void WaitForGameOver(object sender, EventArgs e)
        {
            if (Stats.GameOver)
            {
                // gameover labels
                gameOverLabel.Visible = true;
                restartLabel.Visible = true;
                winnerLabel.Text = Stats.Winner;
                winnerLabel.Visible = true;


                if (Input.GetKeyPressed(Keys.Enter))
                {
                    //hide labels
                    gameOverLabel.Visible = false;
                    restartLabel.Visible = false;
                    winnerLabel.Visible = false;

                    //restart the game
                    ResetGame();
                }
            }
        }

        private void ChangeTurn()
        {
            Stats.ChangeTurns();

            if (!Stats.isPlayerTurn)
            {
                if (!Stats.GameOver)
                    EnemyMove();
            }
        }

        private void EnemyMove()
        {
            //get available squares
            List<Square> available = GetMoves();

            Random r = new Random();

            int rng = r.Next(available.Count);
            
            if (available.Count != 0) // check for game end
            {
                available[rng].ActivateO();

                //refresh square
                available[rng].box.Invalidate();

                //change turn
                if (!CheckWins(0))
                {
                    ChangeTurn();
                } else
                {
                    //gameover
                    Stats.EnemyWins();
                }
            } else // DRAW, enemy no moves and no wins
            {
                //game over
                Stats.Draw();
            }
        }

        private bool CheckWins(int symbolNum)
        {

            if (symbolNum == 0) // checking O's
            {
                for (int i = 0; i < wins.GetLength(0); i++)
                {
                    if (boxes[wins[i, 0]-1].isO && boxes[wins[i, 1]-1].isO && boxes[wins[i, 2]-1].isO)
                        return true;
                }
            } else if (symbolNum == 1)
            {
                for (int i = 0; i < wins.GetLength(0); i++)
                {
                    if (boxes[wins[i, 0]-1].isX && boxes[wins[i, 1]-1].isX && boxes[wins[i, 2]-1].isX)
                        return true;
                }
            }
            

            return false;
        }

        private List<Square> GetMoves()
        {
            List<Square> temp = new List<Square>();

            //get available squares
            foreach (Square sq in boxes)
            {
                if (!sq.isOccupied())
                    temp.Add(sq);
            }

            return temp; // return references
        }

        private void ButtonBoxClick(object sender, EventArgs e)
        {
            if (Stats.isPlayerTurn && !Stats.GameOver)
            {
                if (GetMoves().Count != 0)
                {
                    string name = ((PictureBox)sender).Name.ToString();
                    int ID = int.Parse(name.Substring(name.Length - 1, 1)) - 1;

                    Console.WriteLine("Clicked on: " + name);

                    //checking square status
                    if (!boxes[ID].isOccupied())
                    {
                        boxes[ID].ActivateX();
                        //change turns

                        //update square
                        ((PictureBox)sender).Invalidate();

                        if (!CheckWins(1))
                            ChangeTurn();
                        else
                        {
                            Stats.PlayerWins();
                        }
                    }
                    else if (boxes[ID].isOccupied())
                    {
                        Console.WriteLine("Occupied!");
                    }
                } else //DRAW, no more moves for the player
                {
                    Stats.Draw();
                }
            }

        }

        private void RepaindSqaure(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            string name = ((PictureBox)sender).Name.ToString();
            int ID = int.Parse(name.Substring(name.Length - 1, 1)) - 1;

            //Console.WriteLine("Repainting: " + name);
            //Console.WriteLine("ID: " + ID);
            boxes[ID].Draw(g);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
    }
}

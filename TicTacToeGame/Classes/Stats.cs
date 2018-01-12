using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame.Classes
{
    class Stats
    {
        public static bool GameOver { get; set; }
        public static bool isPlayerTurn { get; set; }
        public static string Winner { get; set; }


        public Stats()
        {
            GameOver = false;
            isPlayerTurn = true;
        }

        public static void ChangeTurns()
        {
            isPlayerTurn = !isPlayerTurn;
        }

        public static void EnemyWins()
        {
            Winner = "Enemy, Wins!";
            GameOver = true;
        }

        public static void PlayerWins()
        {
            Winner = "Player, Wins!";
            GameOver = true;
        }

        public static void Draw()
        {
            Winner = "Draw!";
            GameOver = true;
        }
    }
}

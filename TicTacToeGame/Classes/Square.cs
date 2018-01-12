using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TicTacToeGame.Classes
{
    class Square
    {
        public PictureBox box;
        public int Width, Height;

        private string XText = "X";
        private string OText = "O";

        public bool isX, isO = false;

        public Square(PictureBox box, int Width, int Height)
        {
            this.box = box;
            this.Width = Width;
            this.Height = Height;
        }

        public void ActivateX()
        {
            isX = true;
        }

        public void ActivateO()
        {
            isO = true;
        }

        public bool isOccupied()
        {
            return (isX || isO);
        }

        public void Clear()
        {
            isX = false;
            isO = false;
        }

        public void Draw(Graphics g)
        {
            Font font = new Font("Arial", 60);

            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            if (isX)
            {
                g.DrawString(XText, font, Brushes.Black, box.ClientRectangle, format);
            } else if (isO)
            {
                g.DrawString(OText, font, Brushes.Black, box.ClientRectangle, format);
            }

            
        }
    }
}

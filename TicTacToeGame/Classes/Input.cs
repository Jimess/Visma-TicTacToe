using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace TicTacToeGame.Classes
{
    class Input
    {
        //load keyboard buttons
        private static Hashtable keyboard = new Hashtable();
        private static Hashtable mouse = new Hashtable();

        //check if button is pressed
        public static bool GetKeyPressed(Keys key)
        {
            if (keyboard[key] != null)
            {
                return (bool)keyboard[key];
            }

            return false;
        }

        public static bool GetMouseButtonPressed(MouseButtons mouseButton)
        {
            if (mouse[mouseButton] != null)
            {
                return (bool)mouse[mouseButton];
            }

            return false;
        }

        // if button is pressed the key state in the hashtable is changed
        public static void ChangeState(Keys key, bool state)
        {
            keyboard[key] = state;
        }

        public static void ChangeMouseState(MouseButtons mouseButton, bool state)
        {
            mouse[mouseButton] = state;
        }
    }
}

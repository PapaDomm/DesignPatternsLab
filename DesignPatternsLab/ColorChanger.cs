using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab
{
    internal static class ColorChanger
    {
        public static ConsoleColor colorChanger(string color)
        {
            if (color == "Red")
            {
                return ConsoleColor.Red;
            }
            else if (color == "Green")
            {
                return ConsoleColor.Green;
            }
            else if (color == "White")
            {
                return ConsoleColor.White;
            }
            else if (color == "Blue")
            {
                return ConsoleColor.Blue;
            }
            else if (color == "Gold" || color == "Yellow")
            {
                return ConsoleColor.Yellow;
            }
            else if (color == "Navy")
            {
                return ConsoleColor.DarkBlue;
            }
            else if (color == "Black")
            {
                return ConsoleColor.Black;
            }
            else
            {
                return ConsoleColor.White;
            }
        }
    }
}

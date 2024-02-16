using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab
{
    internal class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country _displayCountry)
        {
            DisplayCountry = _displayCountry;
        }

        public void Display()
        {
            int colorCount = DisplayCountry.Name.Length / DisplayCountry.Colors.Count();
            int currentLetter = 0;

            Console.Write("You chose ");
            while (currentLetter < DisplayCountry.Name.Length)
            {
                for (int i = 0; i < DisplayCountry.Colors.Count; i++)
                {
                    Console.ForegroundColor = ColorChanger.colorChanger(DisplayCountry.Colors[i]);
                    for (int j = 0; j < colorCount; j++)
                    {
                        if (currentLetter < DisplayCountry.Name.Length)
                        {
                            Console.Write($"{DisplayCountry.Name.Substring(currentLetter, 1)}");
                            currentLetter++;
                        }
                    }

                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" which is on the continent of {DisplayCountry.Continent}. ");

            Console.WriteLine("Its flags colors are: ");
            foreach (string color in DisplayCountry.Colors)
            {
                Console.ForegroundColor = ColorChanger.colorChanger(color);
                Console.WriteLine($"{color}  ");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

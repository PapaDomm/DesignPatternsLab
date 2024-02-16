using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movie_Database;

namespace DesignPatternsLab
{
    internal class CountryController
    {
        public List<Country> CountryDb = new List<Country>
        {
            new Country("USA", "North America", new List<string>{"Red", "White", "Blue"}),
            new Country("France", "Europe", new List<string>{"Blue", "White", "Red"}),
            new Country("Russia", "Asia", new List<string>{"White", "Blue", "Red"}),
            new Country("Australia", "Australia", new List<string>{"Green", "Gold"}),
            new Country("Japan", "Asia", new List<string>{"White", "Red"}),
            new Country("Brazil", "South America", new List<string>{"Green", "Yellow", "Blue"}),
            new Country("Antartica", "Antartica", new List<string>{"Navy", "White"}),
            new Country("Egypt", "Africa", new List<string>{"Red", "White", "Black"})
        };

        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display();
        }
        public void WelcomeAction()
        {
            bool runWelcomeAction = true;

            while (runWelcomeAction)
            {
                CountryListView view = new CountryListView(CountryDb);
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");
                view.Display();
                int choice = Validator.getValidInt(1, CountryDb.Count()) - 1;
                CountryAction(CountryDb[choice]);
                runWelcomeAction = Validator.getContinue("Would you like to learn about another Country? ");
                Console.Clear();
            }
        }
    }
}

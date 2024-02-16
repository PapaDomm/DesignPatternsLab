﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab
{
    internal class CountryListView
    {
        public List<Country> Countries { get; set; }

        public CountryListView(List<Country> _Countries) 
        {
            Countries = _Countries;
        }
        public void Display()
        {
            for (int i = 0; i < Countries.Count(); i++)
            {
                Console.WriteLine($"{i + 1}- {Countries[i].Name}");
            }
        }
    }
}


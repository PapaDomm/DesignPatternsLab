using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab
{
    internal class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string> Colors { get; set; }

        public Country(string _Name, string _Continent, List<string> _Colors) 
        {
            Name = _Name;
            Continent = _Continent;
            Colors = _Colors;
        }
    }
}

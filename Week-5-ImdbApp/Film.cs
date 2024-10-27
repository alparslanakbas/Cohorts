using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_ImdbApp
{
    public class Film
    {
        public string Name { get; set; }
        public double Imdb { get; set; }

        public Film(string name, double imdb)
        {
            Name = name;
            Imdb = imdb;
        }
    }
}

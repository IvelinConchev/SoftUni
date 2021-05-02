using System;
using System.Collections.Generic;
using System.Text;

namespace Dice
{
    class Dice
    {
        public Dice(int sides)
        {
            Sides = sides; 
        }
        public int Sides { get; set; }

        public string Type { get; set; }

       public int Roll()
        {
            Random rnd = new Random();

            return rnd.Next(1, Sides + 1);
        }
    }
}

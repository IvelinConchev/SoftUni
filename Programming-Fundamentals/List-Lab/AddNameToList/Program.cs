using System;
using System.Collections.Generic;

namespace AddNameToList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> names = new List<string>();
            names.Add("Ivo");
            names.Add("Pesho");
            names.Add("Milena");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(string.Join(" ", names));
        }
    }
}

using System;
using System.Collections.Generic;

namespace SortList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            { "Ivelin" ,"Angel", "Velizar", "Zlatan"};

            names.Sort();
            names.Reverse();

            Console.WriteLine(string.Join(", ", names));
        }

    }
}

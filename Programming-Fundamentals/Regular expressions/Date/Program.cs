using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"((?:[1-3]?[0-9])|(?:3[01]))-([A-Z][a-z]{2})-([0-9]{4})";
            string whitespace = @"\s+";

            var regex = new Regex(whitespace);

            string text = "2   4   3  1  5  5  7 5 66 4 444 3 0";
            int[] arr = Regex.Split(text, whitespace)
                .Select(int.Parse)
                .ToArray();

            //var regex = new Regex(pattern);
            //string text = "Today is 15-Nov-2020";
           //text = regex.Replace(text, "today");

            Console.WriteLine(text);
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates_OtherVer2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(\d{2})(.)([A-Z][a-z]+)\2(\d{4})";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);


            //MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match date in matches)
            {
                Console.WriteLine($"Day: {date.Groups[1]}, Month: {date.Groups[3]}, Year: {date.Groups[4]}");
            }
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b([0-9]{2})([\/\.\-])([A-Z][a-z]{2})(\2)(\d{4})\b";

            MatchCollection dates = Regex.Matches(input, pattern);

            foreach (Match date in dates)
            {
                string day = date.Groups[1].Value;
                string month = date.Groups[3].Value;
                string year = date.Groups[5].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}

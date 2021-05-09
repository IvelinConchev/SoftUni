using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates_OtherVer_
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b([0-9]{2})([\/\.\-])([A-Z][a-z]{2})(\2)(\d{4})\b";
            //var regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b";

            var datesString = Console.ReadLine();

            var dates = Regex.Matches(datesString, regex);

            foreach (Match date in dates)
            {
                var day = date.Groups[1].Value;
                var month = date.Groups[3].Value;
                var year = date.Groups[5].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumber = Console.ReadLine();

           // string pattern = @"\+([359]+)(-| )([2])(-| )([0-9]{3})(-| )([0-9]{4})";
            string pattern = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";


            // Regex regex = new Regex(pattern);

            //var matches = regex.Matches(phoneNumber);

            var phoneMatches = Regex.Matches(phoneNumber, pattern);

            string[] matchedPhone = phoneMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhone));
        }
    }
}

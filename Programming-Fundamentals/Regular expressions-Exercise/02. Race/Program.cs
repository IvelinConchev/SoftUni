using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listOfPeople = Console.ReadLine().Split(", ");

            Dictionary<string, int> dictionaryOfName = new Dictionary<string, int>();

            foreach (var name in listOfPeople)
            {
                dictionaryOfName.Add(name, 0);
            }

            string namePattern = @"[\W\d]";
            string numberPattern = @"[\WA-Za-z]";

            string input;

            while ((input = Console.ReadLine()) != "end of race")
            {
                string name = Regex.Replace(input, namePattern, "");
                string distance = Regex.Replace(input, numberPattern, "");

                int sum = 0;

                foreach (char digit in distance)
                {
                    int currentDigit = int.Parse(digit.ToString());
                    sum += currentDigit;
                }

                if (dictionaryOfName.ContainsKey(name))
                {
                    dictionaryOfName[name] += sum;
                }
            }
            int count = 1;

            foreach (var kvp in dictionaryOfName.OrderByDescending(x =>x.Value))
            {
                string output = string.Empty;
                string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";
                /*
                if (count == 1)
                {
                    output = "st";
                }
                else if (count == 2)
                {
                    output = "nd";
                }
                else if (count == 3)
                {
                    output = "rd";
                }
                */

                Console.WriteLine($"{count++}{text} place: {kvp.Key}");
                if (count == 4)
                {
                    break;
                }
            }
        }
    }
}

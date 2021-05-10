using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma_OtherVar_
{
    class Program
    {
        static void Main(string[] args)
        {
            int countMesseges = int.Parse(Console.ReadLine());

            string firstPattern = @"[starSTAR]";

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < countMesseges; i++)
            {
                string message = Console.ReadLine();

                MatchCollection lettersMatches = Regex.Matches(message, firstPattern);

                int countOfLetter = lettersMatches.Count;

                string newMessage = string.Empty;

                foreach (var letter in message)
                {
                    newMessage += (char)(letter - countOfLetter);
                }

                string planetPattern = @"@(?<planet>[A-Z][a-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<attack>[A|D])![^@\-!:>]*->(?<soldiers>\d+)";

                Match planetArgs = Regex.Match(newMessage, planetPattern);

                if (planetArgs.Success)
                {
                    string planet = planetArgs.Groups["planet"].Value;
                    string attack = planetArgs.Groups["attack"].Value;

                    if (attack == "A")
                    {
                        attackedPlanets.Add(planet);
                    }
                    else if (attack == "D")
                    {
                        destroyedPlanets.Add(planet);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var attackedPlanet in attackedPlanets.OrderBy(pl => pl))
            {
                Console.WriteLine($"-> {attackedPlanet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var destroyedPlanet in destroyedPlanets.OrderBy(pl => pl))
            {
                Console.WriteLine($"-> {destroyedPlanet}");
            }
        }
    }
}

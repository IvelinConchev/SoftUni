using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> atacktPlanets = new List<string>();
            List<string> destroyPlanets = new List<string>();

            string pattern = @"@(?<planet>[A-Z][a-z]+)[^@\-!:>]*\:(?<population>\d+)[^@\-!:>]*!(?<atack>[A|D])![^@\-!:>]*->(?<soldier>\d+)";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                int specialNumber = SpecialLettersCount(encryptedMessage);
                string decryptedMessage = DecryptMessage(encryptedMessage, specialNumber);

                Match match = Regex.Match(decryptedMessage, pattern);

                if (match.Success)
                {
                    string planet = match.Groups["planet"].Value;
                    //int population = int.Parse(match.Groups["population"].Value);
                    //int soldier = int.Parse(match.Groups["soldier"].Value);
                    string atack = match.Groups["atack"].Value;

                    if (atack == "A")
                    {
                        atacktPlanets.Add(planet);
                    }
                    else
                    {
                        destroyPlanets.Add(planet);
                    }
                }
            }

            PrintOutputForPlanets(atacktPlanets, "Attacked");
            PrintOutputForPlanets(destroyPlanets, "Destroyed");
        }

        private static void PrintOutputForPlanets(List<string> planets, string atact)
        {
            Console.WriteLine($"{atact} planets: {planets.Count}");

            foreach (string planet in planets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }

        private static string DecryptMessage(string encrypted, int key)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < encrypted.Length; i++)
            {
                char currentCh = encrypted[i];
                char decryptedCh = (char)(currentCh - key);

                sb.Append(decryptedCh);
            }
            return sb.ToString();
        }

        private static int SpecialLettersCount(string message)
        {
            char[] specialLetters = new char[] { 's', 't', 'a', 'r'};

            int specialLettersCount = 0;

            for (int i = 0; i < message.Length; i++)
            {
                char currentCh = message[i];

                if (specialLetters.Contains(char.ToLower(currentCh)))
                {
                    specialLettersCount++;
                }
            }
            return specialLettersCount;
        }
    }
}

using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonims = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (synonims.ContainsKey(word))
                {
                    synonims[word].Add(synonim);
                }
                else
                {
                    synonims.Add(word, new List<string>() { synonim });
                }
            }
            foreach (var synonim in synonims)
            {
                Console.WriteLine($"{synonim.Key} - {string.Join(", ", synonim.Value)}");
            }
        }
    }
}

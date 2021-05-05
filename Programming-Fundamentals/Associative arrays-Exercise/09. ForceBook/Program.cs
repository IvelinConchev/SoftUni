using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> facebook = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] arrArgOne = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                    string type = arrArgOne[0];
                    string name = arrArgOne[1];

                    if (!facebook.ContainsKey(type))
                    {
                        facebook.Add(type, new List<string> { name });
                    }
                    if (!facebook[type].Contains(name))
                    {
                        facebook[type].Add(name);
                    }
                }
                else if (input.Contains("->"))
                {
                    string[] arrArgTwo = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string type = arrArgTwo[0];
                    string name = arrArgTwo[1];

                    if (!facebook.ContainsKey(name))
                    {
                        facebook.Add(name, new List<string> { type });
                    }
                    facebook[name].Add(type);
                    Console.WriteLine($"{type} joins the {name} side!");

                }
            }
            foreach (var item in facebook.OrderBy(x => x.Key))
            {
                Console.WriteLine($"Side: { item.Key}, Members: { item.Value.Count}");
                
                
                    Console.WriteLine($"! {item.Value}");
                
            }
        }
    }
}

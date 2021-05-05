using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> academy = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!academy.ContainsKey(name))
                {
                    academy.Add(name, new List<double>());
                }
                academy[name].Add(grade);

            }
            foreach (var item in academy.OrderByDescending(x => x.Value.Average()))
            {
                if (item.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
                }
            }

        }
    }
}

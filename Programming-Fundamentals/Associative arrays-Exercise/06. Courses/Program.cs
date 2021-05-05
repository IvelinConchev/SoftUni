using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> cources = new Dictionary<string, List<string>>();
            int counter = 0;

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] arrArg = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = arrArg[0];
                string registeredStudents = arrArg[1];

                if (!cources.ContainsKey(courseName))
                {
                    cources.Add(courseName, new List<string>());
                }
                cources[courseName].Add(registeredStudents);
                counter++;
            }
            foreach (var item in cources.OrderByDescending(u => u.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var name in item.Value.OrderBy(n => n))
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}

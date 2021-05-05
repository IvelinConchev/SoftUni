using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] arrArg = input.Split(" -> ");
                string companyName = arrArg[0];
                string employeedId = arrArg[1];

                if (!company.ContainsKey(companyName))
                {
                    company.Add(companyName, new List<string>());
                }
                if (!company[companyName].Contains(employeedId))
                {
                company[companyName].Add(employeedId);
                }
            }
            //var list = company.OrderBy(k => k.Key)
            //    .ThenBy(k => k.Value)
            //    .ToDictionary(k => k.Key, k => k.Value);


            foreach (var item in company.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var comp in item.Value)
                {
                    Console.WriteLine($"-- {comp}");
                }
            }
        }
    }
}

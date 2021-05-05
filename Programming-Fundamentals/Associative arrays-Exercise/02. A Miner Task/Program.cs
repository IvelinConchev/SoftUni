using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> minerTask = new Dictionary<string, int>();

            string resource;

            while ((resource = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!minerTask.ContainsKey(resource))
                {
                    minerTask.Add(resource, quantity);
                }
                else
                {
                    minerTask[resource] += quantity;
                }
            }
            foreach (var item in minerTask)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

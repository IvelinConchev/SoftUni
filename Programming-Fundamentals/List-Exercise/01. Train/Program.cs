using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int capacity = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] currentPassengers = command.Split();

                if (currentPassengers[0] == "Add")
                {
                    wagons.Add(int.Parse(currentPassengers[1]));
                }
                else
                {
                    int passengers = int.Parse(currentPassengers[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currentWagon = wagons[i];
                        bool enoughSpace = currentWagon + passengers <= capacity;

                        if (enoughSpace)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }

            }
            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            double sumLeft = 0;
            double sumRight = 0;

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                double leftCar = numbers[i];
                if (leftCar == 0)
                {
                    sumLeft *= 0.8;
                }
                else
                {
                sumLeft += leftCar;
                }
            }
            for (int i = numbers.Count - 1; i > numbers.Count / 2; i--)
            {
                double rightCar = numbers[i];
                if (rightCar != 0)
                {
                    sumRight += rightCar;
                }
                else
                {
                    sumRight *= 0.8;
                }
            }
            if (sumRight < sumLeft)
            {
                Console.WriteLine($"The winner is right with total time: {sumRight}");
            }
            else
            {
                Console.WriteLine($"The winner is left with total time: {sumLeft}");
            }
        }
    }
}

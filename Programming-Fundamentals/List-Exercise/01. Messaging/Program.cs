using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<string> words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int sum = 0;
            int countIndex = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];

                while (number > 0)
                {
                    int currentNumber = number % 10;
                    sum += currentNumber;
                    number /= 10;
                }
            }
           // int sum = 0;
            for (int i = 0; i < sum; i++)
            {
                countIndex++;
                if (countIndex == words.Count)
                {
                    countIndex = 0;
                }

            }

        }
    }
}

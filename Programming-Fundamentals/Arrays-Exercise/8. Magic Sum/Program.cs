using System;
using System.Linq;

namespace _8._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int magicNumber = int.Parse(Console.ReadLine());

            for (int curr = 0; curr < numbers.Length; curr++)
            {
                int cuurrent = numbers[curr];
                for (int i = curr + 1; i < numbers.Length; i++)
                {
                    if (cuurrent + numbers[i] == magicNumber)
                    {
                        Console.WriteLine($"{cuurrent} {numbers[i]}");
                    }
                }
            }
        }
    }
}

using System;
using System.Linq;

namespace _6._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int sumEven = 0;
            int sumOdd = 0;
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];

                if (current % 2 == 0)
                {
                    sumEven += current;
                }
                else
                {
                    sumOdd += current;
                }

            }
            result = sumEven - sumOdd;
            Console.WriteLine(result);
        }
    }
}

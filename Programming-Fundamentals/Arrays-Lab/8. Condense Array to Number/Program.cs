using System;
using System.Linq;

namespace _8._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }

            for (int i = 0; i < numbers.Length -1; i++)
            {
                for (int j = 0; j < numbers.Length -1; j++)
                {
                    numbers[j] += numbers[j + 1];
                }
            }
            Console.WriteLine(numbers[0]);
        }
    }
}

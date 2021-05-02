using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _02._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            //int number = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];
                for (int j = 1; j <= number; j++)
                {
                    factorial *= j;

                }
            }

            Console.WriteLine(factorial);

            //int numbers = int.Parse(Console.ReadLine());

            //BigInteger factorial = 1;

            //for (int i = 1; i <= numbers; i++)
            //{
            //    factorial *= i;
            //}
            //Console.WriteLine(factorial);
        }
    }
}

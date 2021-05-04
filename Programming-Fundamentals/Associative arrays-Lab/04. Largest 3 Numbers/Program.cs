using System;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n)).OrderByDescending(n => n)
                .ToArray();
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int result = numbers[i];
                counter++;
                if (counter > 3)
                {
                    break;
                }
                else
                {
                    Console.Write(result + " ");
                }
            }
        }
    }
}

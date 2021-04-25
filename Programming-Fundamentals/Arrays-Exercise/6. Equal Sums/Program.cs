using System;
using System.Linq;

namespace _6._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool isFound = false;

            for (int curr = 0; curr < numbers.Length; curr++)
            {
                int sumRight = 0;
                for (int i = curr + 1; i < numbers.Length; i++)
                {
                    sumRight += numbers[i];
                }
                int sumLeft = 0;
                for (int i = curr - 1; i >= 0; i--)
                {
                    sumLeft += numbers[i];
                }
                if (sumRight == sumLeft)
                {
                    Console.WriteLine(curr);
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}

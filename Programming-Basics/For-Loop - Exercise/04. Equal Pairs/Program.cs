using System;

namespace _04._Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int sum = 0;
            int previousSum = firstNum + secondNum;
            int maxDiff = 0;

            for (int i = 0; i < number - 1; i++)
            {
                firstNum = int.Parse(Console.ReadLine());
                secondNum = int.Parse(Console.ReadLine());

                sum = firstNum + secondNum;
                int diff = Math.Abs(sum - previousSum);

                if (diff > maxDiff)
                {
                    maxDiff = diff;
                }
                previousSum = sum;
            }
            if (maxDiff != 0)
            {
                Console.WriteLine("No, maxdiff=" + maxDiff);
            }
            else
            {
                Console.WriteLine("Yes, value=" + previousSum);
            }
        }
    }
}


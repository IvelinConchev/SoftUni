using System;

namespace _05._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            //int sum = 0;
            int pOneCount = 0;
            int pTwoCount = 0;
            int pThreeCount = 0;
            int pFourCount = 0;
            int pFiveCount = 0;

            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    pOneCount++;
                }
                else if (num < 400)
                {
                    pTwoCount++;
                }
                else if (num < 600)
                {
                    pThreeCount++;
                }
                else if (num < 800)
                {
                    pFourCount++;
                }
                else
                {
                    pFiveCount++;
                }

            }
            Console.WriteLine($"{pOneCount * 1.0 / number * 100}%");
            Console.WriteLine($"{pTwoCount * 1.0 / number * 100}%");
            Console.WriteLine($"{pThreeCount * 1.0 / number * 100}%");
            Console.WriteLine($"{pFourCount * 1.0 / number * 100}%");
            Console.WriteLine($"{pFiveCount * 1.0 / number * 100}%");
        }
    }
}

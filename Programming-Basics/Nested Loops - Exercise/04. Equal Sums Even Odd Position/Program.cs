using System;

namespace _04._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                int num = i;
                int evenSum = 0;
                int oddSum = 0;
                int counter = 0;

                while (num > 0)
                {
                    int digit = num % 10;
                    num /= 10;
                    counter++;

                    if (counter % 2 == 0)
                    {
                        oddSum += digit;
                    }
                    else
                    {
                        evenSum += digit;
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

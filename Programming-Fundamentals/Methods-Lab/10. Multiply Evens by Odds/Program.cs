using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int result = GetSumOfOddDigits(number) * GetSumOfEvenDigits(number);
            return result;
        }

        static int GetSumOfEvenDigits(int numbers)
        {
            int sumEven = 0;
            while (numbers > 0)
            {
                int nextNum = numbers % 10;

                if (nextNum % 2 == 0)
                {
                    sumEven += nextNum;
                }
                numbers -= nextNum;
                numbers /= 10;
            }
            return sumEven;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sumOdd = 0;
            while (number > 0)
            {
                int nextNum = number % 10;
                if (nextNum % 2 != 0)
                {
                    sumOdd += nextNum;
                }
                number -= nextNum;
                number /= 10;
            }
            return sumOdd;
        }
    }
}


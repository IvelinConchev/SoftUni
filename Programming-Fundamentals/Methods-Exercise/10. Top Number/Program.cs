using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            PrrintTopInteger(numbers);
            //Console.WriteLine(numbers);
        }

        private static void PrrintTopInteger(int numbers)
        {
            for (int i = 0; i <= numbers; i++)
            {
                string currentNumber = i.ToString();
                bool isOddDigit = false;
                int sumOfDigits = 0;

                foreach (var curr in currentNumber)
                {
                    int parseNumber = (int)curr;
                    if (parseNumber % 2 != 0)
                    {
                        isOddDigit = true;
                    }
                    sumOfDigits += parseNumber;
                }
                if (sumOfDigits % 8 == 0 && isOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

using System;

namespace _1._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            PrintNumbers(numbers);
        }

        static void PrintNumbers(int numbers)
        {
            string result = string.Empty;
            if (numbers > 0)
            {
                result = $"The number {numbers} is positive.";
            }
            else if (numbers < 0)
            {
                result = $"The number {numbers} is negative.";
            }
            else if (numbers == 0)
            {
                result = $"The number {numbers} is zero.";
            }
            Console.WriteLine(result);
        }
    }
}

using System;

namespace _2._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;

            while (numbers > 0)
            {
                int digit = numbers % 10;
                sum += digit;
                numbers /= 10;

            }
            Console.WriteLine(sum);
        }
    }
}

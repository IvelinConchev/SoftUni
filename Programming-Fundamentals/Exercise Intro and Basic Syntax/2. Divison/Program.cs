using System;

namespace _2._Divison
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = 1;

            if (number % 10 == 0)
            {
                result = number % 10;
                Console.WriteLine($"The number is divisible by 10");
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine($"The number is divisible by 7");
            }
            else if (number % 6 == 0)
            {
                Console.WriteLine($"The number is divisible by 6");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine($"The number is divisible by 3");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine($"The number is divisible by 2");
            }
            else
            {
                Console.WriteLine($"Not divisible");
            }
        }
    }
}

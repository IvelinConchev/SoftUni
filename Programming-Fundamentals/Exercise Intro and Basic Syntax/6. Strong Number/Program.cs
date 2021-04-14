using System;

namespace _6._Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int mod = 1;
            int sum = 0;
            int number = numberOne;
            while (number > 0)
            {
                mod = number % 10;
                number /= 10;

                int fact = 1;
                for (int i = 1; i <= mod; i++)
                {
                    fact = fact * i;
                }
                sum += fact;
                if (numberOne == sum)
                {
                    break;
                }
            }
            if (numberOne == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

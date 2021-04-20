using System;

namespace _7._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int capacity = 255;

            for (int i = 1; i <= n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                sum += liters;
                if (sum > capacity)
                {
                    sum -= liters;
                    Console.WriteLine($"Insufficient capacity!");
                }
            }
            Console.WriteLine(sum);
        }
    }
}

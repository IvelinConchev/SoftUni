using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minets = int.Parse(Console.ReadLine());

            minets = minets + 15;
            if (minets > 59)
            {
                hours++;
                minets = minets - 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            if (minets < 10)
            {
                Console.WriteLine($"{hours}:0{minets}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minets}");
            }
        }
    }
}
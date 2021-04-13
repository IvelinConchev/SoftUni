using System;

namespace _4._Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            seconds += 30;

            if (seconds >= 60)
            {
                hours++;
                seconds -= 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{seconds:d2}");

        }
    }
}

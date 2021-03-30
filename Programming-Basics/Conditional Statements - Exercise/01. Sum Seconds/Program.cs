using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlay = int.Parse(Console.ReadLine());
            int secondPlay = int.Parse(Console.ReadLine());
            int thirdPlay = int.Parse(Console.ReadLine());

            int sum = firstPlay + secondPlay + thirdPlay;
            double minutes = sum / 60;
            double second = sum % 60;

            if (second < 10)
            {
            Console.WriteLine($"{minutes}:0{second}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{second}");
            }
        }       
    }
}

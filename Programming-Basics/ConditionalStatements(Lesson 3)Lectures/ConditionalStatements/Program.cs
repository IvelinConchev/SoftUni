using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime + secondTime + thirdTime;// 150
            int minutes = totalTime / 60;

            // First variant
            int seconds = totalTime - minutes * 60;

            // Second variant
            seconds = totalTime % 60;
            Console.WriteLine("{0}:{1:00}", minutes, seconds);
        }
    }
}

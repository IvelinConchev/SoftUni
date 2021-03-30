using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordToSecond = double.Parse(Console.ReadLine());
            double distanceToMeters = double.Parse(Console.ReadLine());
            double timeInSecond = double.Parse(Console.ReadLine());

            double ivanTimeSecond = distanceToMeters * timeInSecond;
            double resistanceToWater = (Math.Floor(distanceToMeters / 15)) * 12.5;
           // double time = ivanTimeSecond + resistanceToWater;
            double sum = ivanTimeSecond + resistanceToWater;

            if (recordToSecond > sum)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {sum:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(sum - recordToSecond):f2} seconds slower.");
            }
        }
    }
}

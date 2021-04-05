using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;
            int steps = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    steps = int.Parse(Console.ReadLine());
                    totalSteps += steps;
                    if (totalSteps >= 10000)
                    {
                        Console.WriteLine($"Goal reached! Good job!");
                    }
                    else
                    {
                        Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
                    }
                    break;
                }
                else
                {
                    steps = int.Parse(input);
                }
                totalSteps += steps;
                if (totalSteps >= 10000)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                }
                break;
            }
        }
    }
}

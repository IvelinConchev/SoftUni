using System;

namespace _06._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            int currentMin = int.MaxValue;
            while (counter < n)
            {
                int nextNum = int.Parse(Console.ReadLine());
                if (nextNum < currentMin)
                {
                    currentMin = nextNum;
                }
                counter++;
            }
            Console.WriteLine(currentMin );
        }
    }
}

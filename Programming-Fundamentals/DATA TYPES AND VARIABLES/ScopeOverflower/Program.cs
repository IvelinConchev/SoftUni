using System;

namespace ScopeOverflower
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 0; i < 260; i++)
            {
                counter++;
                Console.WriteLine(counter);
            }

        }
    }
}

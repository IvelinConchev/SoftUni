using System;

namespace _09._Numbers_NTo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            for (int i = m; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}

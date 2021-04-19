using System;

namespace Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal britishPound = decimal.Parse(Console.ReadLine());

            decimal dollar = britishPound * 1.31m;
            Console.WriteLine($"{dollar:f3}");

            //double max = double.MaxValue;
            //double min = double.MinValue;

            //Console.WriteLine(max);
            //Console.WriteLine(min);
        }
    }
}

using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string text1 = Console.ReadLine();
            string text2 = Console.ReadLine();
            //int meter = 0;

            if (text1 == "mm")
            {
                double meter = number * 0.001;
                Console.WriteLine($"{meter:f3}");
            }
            else if (text1 == "m")
            {
                double centemeter = number * 100;
                Console.WriteLine($"{centemeter:f3}");
            }
            else if (text1 == "cm")
            {
                double millimeters = number * 10;
                Console.WriteLine($"{millimeters:f3}");
            }
        }
    }
}

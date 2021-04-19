using System;

namespace Convert_Meters_to_Kilometres
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal metters = decimal.Parse(Console.ReadLine());

            decimal kilometters = metters / 1000;
            Console.WriteLine($"{kilometters:f2}");
        }
    }
}

using System;

namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = length * width * height;
            double fullLiter = volume * 0.001;
            double percentDown = percent * 0.01;
            double liters = fullLiter * (1 - percentDown);
            Console.WriteLine("{0:F3}", liters);
        }
    }
}

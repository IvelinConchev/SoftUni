using System;

namespace _06._Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            double peremeter = 2 * Math.PI * radius;
            Console.WriteLine("{0:F2}", area);
            Console.WriteLine("{0:F2}", peremeter);
        }
    }
}

using System;

namespace _05._Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double side = double.Parse(Console.ReadLine());

            double area = (length * 100) * (width * 100);
            double wardrobe = side *  side * length * side * side * length;
            double bench = area / 10;
            double freeSpace = area - wardrobe - bench;
            double dance = freeSpace / (40 + 7000);
            Console.WriteLine(Math.Floor(dance));
        }
    }
}

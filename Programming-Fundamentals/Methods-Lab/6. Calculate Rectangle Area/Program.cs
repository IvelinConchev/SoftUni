using System;

namespace _6._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int area = PrintArea(width, height);
            Console.WriteLine(area);
        }

        static int PrintArea(int width, int height)
        {
            int area = width * height;
            //Console.WriteLine(area);
            return area;
        }

    }
}

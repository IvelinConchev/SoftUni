using System;

namespace _07._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int animals = int.Parse(Console.ReadLine());
            double food = dogs * 2.5 + animals * 4;
            Console.WriteLine("{0:F2} lv." , food);
        }
    }
}

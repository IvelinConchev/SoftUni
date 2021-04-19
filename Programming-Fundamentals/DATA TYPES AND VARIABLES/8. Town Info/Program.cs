using System;

namespace _8._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameTown = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {nameTown} has population of {population} and area {area} square km.");
        }
    }
}

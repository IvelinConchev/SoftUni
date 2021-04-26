using System;

namespace _5._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            PrintOrder(type, number);
        }

        static void PrintOrder(string type, int number)
        {
            decimal result = 0;
            if (type == "coffee")
            {
                result = number * 1.50m;
            }
            else if (type == "water")
            {
                result = number * 1.00m;
            }
            else if (type == "coke")
            {
                result = number * 1.40m;
            }
            else
            {
                result = number * 2.00m;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}

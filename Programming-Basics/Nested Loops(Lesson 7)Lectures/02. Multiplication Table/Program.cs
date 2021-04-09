using System;

namespace _02._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x <= 10; x++)
            {
                for (int y = 0; y <= 10; y++)
                {
                    int product = x * y;
                    Console.WriteLine($"{x} * {y} = {product}");
                }
            }
        }
    }
}

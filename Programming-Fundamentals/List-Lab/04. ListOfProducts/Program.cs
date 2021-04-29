using System;
using System.Collections.Generic;

namespace _04._ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < numbers; i++)
            {
                string prod = Console.ReadLine();
                products.Add(prod);
            }
                products.Sort();
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
            
        }
    }
}

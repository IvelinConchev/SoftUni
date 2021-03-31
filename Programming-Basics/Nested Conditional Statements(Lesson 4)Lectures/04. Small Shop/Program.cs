using System;

namespace _04._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            decimal quantity = decimal.Parse(Console.ReadLine());


            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.50m);
                }
                else if (product == "water")
                {
                    Console.WriteLine(quantity * 0.80m);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.20m);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.45m);
                }
                else
                {
                    Console.WriteLine(quantity * 1.60m);
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.40m);
                }
                else if (product == "water")
                {
                    Console.WriteLine(quantity * 0.70m);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.15m);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.30m);
                }
                else
                {
                    Console.WriteLine(quantity * 1.50m);
                }
            }
            else  
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.45m);
                }
                else if (product == "water")
                {
                    Console.WriteLine(quantity * 0.70m);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.10m);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.35m);
                }
                else
                {
                    Console.WriteLine(quantity * 1.55m);
                }
            }
        }
    }
}

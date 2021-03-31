using System;

namespace _04._Small_Shop_switch_case_
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double totalPrice = 0;

            switch (town)
            {
                case "Sofia":
                    if (product == "coffee")
                    {
                        Console.WriteLine(quantity * 0.50);
                        break;
                    }

                    if (product == "water")
                    {
                        Console.WriteLine(quantity * 0.80);
                        break;
                    }
                    if (product == "beer")
                    {
                        Console.WriteLine(quantity * 1.20);
                        break;
                    }
                    if (product == "sweets")
                    {
                        Console.WriteLine(quantity * 1.45);
                        break;
                    }
                    if (product == "peanuts")
                    {
                        Console.WriteLine(quantity * 1.60);
                        break;
                    }
                    break;
                case "Plovdiv":
                    if (product == "coffee")
                    {
                        Console.WriteLine(quantity * 0.40);
                        break;
                    }

                    if (product == "water")
                    {
                        Console.WriteLine(quantity * 0.70);
                        break;
                    }
                    if (product == "beer")
                    {
                        Console.WriteLine(quantity * 1.15);
                        break;
                    }
                    if (product == "sweets")
                    {
                        Console.WriteLine(quantity * 1.30);
                        break;
                    }
                    if (product == "peanuts")
                    {
                        Console.WriteLine(quantity * 1.50);
                        break;
                    }
                    break;
                case "Varna":
                    if (product == "coffee")
                    {
                        Console.WriteLine(quantity * 0.45);
                        break;
                    }

                    if (product == "water")
                    {
                        Console.WriteLine(quantity * 0.70);
                        break;
                    }
                    if (product == "beer")
                    {
                        Console.WriteLine(quantity * 1.10);
                        break;
                    }
                    if (product == "sweets")
                    {
                        Console.WriteLine(quantity * 1.35);
                        break;
                    }
                    if (product == "peanuts")
                    {
                        Console.WriteLine(quantity * 1.55);
                        break;
                    }
                    break;
               // default:
            }
            //Console.WriteLine("{0:f2}", totalPrice );
        }
    }
}

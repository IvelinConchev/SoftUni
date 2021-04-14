using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal price = 0;
            string input;
            decimal number = 0;
            decimal sum = 0;
            decimal curr = 0;

            while ((input = Console.ReadLine()) != "Start")
            {
                number = decimal.Parse(input);
                if ((number != 2) && (number != 1) &&
                    (number != 0.5m) && (number != 0.2m) && (number != 0.1m))
                {

                    Console.WriteLine($"Cannot accept {number}");
                }
                else
                {
                    sum += number;

                }
            }
            string type = Console.ReadLine().ToLower();
            while (type != "end")
            {
                if (type == "nuts")
                {
                    price = 2;
                }
                else if (type == "water")
                {
                    price = 0.7m;
                }
                else if (type == "crisps")
                {
                    price = 1.5m;
                }
                else if (type == "soda")
                {
                    price = 0.8m;
                }
                else if (type == "coke")
                {
                    price = 1.0m;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    break;
                }
                //sum -= price;

                if ((sum < price) && (sum > 0))
                {
                    //sum -= price;
                    Console.WriteLine($"Sorry, not enough money");
                    
                    // Console.WriteLine($"Change: {sum:f2}");
                     //break;
                }
                else
                {
                    sum -= price;
                    Console.WriteLine($"Purchased {type}");
                }
               // sum -= price;
                type = Console.ReadLine().ToLower();
            }
            //if (sum > 0)
            // {
            //    Console.WriteLine($"Sorry, not enough money Change: {sum}");
            // }
            //else
            //{
            //    Console.WriteLine($"Purchased {type}");
            //}
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}

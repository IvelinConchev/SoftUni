using System;

namespace _08._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            decimal quantity = decimal.Parse(Console.ReadLine());

            decimal totalPrice = 0.0m;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" ||
                day == "Thursday" || day == "Friday")
            {
                if (product == "banana")
                {
                    totalPrice = quantity * 2.50m;
                    //Console.WriteLine($"{ totalPrice}");
                }
                else if (product == "apple")
                {
                    totalPrice = quantity * 1.20m;
                    //Console.WriteLine($"{totalPrice}");
                }
                else if (product == "orange")
                {
                    totalPrice = quantity * 0.85m;
                   // Console.WriteLine($"{totalPrice}");
                }
                else if (product == "grapefruit")
                {
                    totalPrice = quantity * 1.45m;
                    //Console.WriteLine($"{totalPrice}");
                }
                else if (product == "kiwi")
                {
                    totalPrice = quantity * 2.70m;
                    //Console.WriteLine($"{totalPrice}");
                }
                else if (product == "pineapple")
                {
                    totalPrice = quantity * 5.50m;
                    //Console.WriteLine($"{totalPrice}");
                }
                else if (product == "grapes")
                {
                    totalPrice = quantity * 3.85m;
                    //Console.WriteLine($"{totalPrice}");
                }
                //else
                //{
                //    Console.WriteLine("error");
                //}
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (product == "banana")
                {
                    totalPrice = quantity * 2.70m;
                    //Console.WriteLine($"{totalPrice}");
                }
                else if (product == "apple")
                {
                    totalPrice = quantity * 1.25m;
                    //Console.WriteLine($"{totalPrice}");
                }
                else if (product == "orange")
                {
                    totalPrice = quantity * 0.90m;
                    //Console.WriteLine($"{totalPrice}");
                }
                else if (product == "grapefruit")
                {
                    totalPrice = quantity * 1.60m;
                    //Console.WriteLine($"{totalPrice}");
                }
                else if (product == "kiwi")
                {
                    totalPrice = quantity * 3.00m;
                    //Console.WriteLine($"{totalPrice}");
                }
                else if (product == "pineapple")
                {
                    totalPrice = quantity * 5.60m;
                    //Console.WriteLine($"{totalPrice}");
                }
                else if (product == "grapes")
                {
                    totalPrice = quantity * 4.20m;
                    
                }
                //else
                //{
                //    Console.WriteLine("error");
                //}
            }
            if (totalPrice > 0)
            {
                Console.WriteLine($"{totalPrice:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
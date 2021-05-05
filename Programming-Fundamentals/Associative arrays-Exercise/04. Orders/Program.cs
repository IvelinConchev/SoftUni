using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> oreders = new Dictionary<string, List<double>>();

            string input;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] arrArgs = input.Split();
                string product = arrArgs[0];
                double price = double.Parse(arrArgs[1]);
                int quantity = int.Parse(arrArgs[2]);

                if (!oreders.ContainsKey(product))
                {
                    List<double> priceAndQuantity = new List<double> { price, quantity };
                    oreders.Add(product, priceAndQuantity);
                    //oreders.Add(product, new List<double> { price, quantity });
                }
                else
                {
                    oreders[product][0] = price;
                    oreders[product][1] += quantity;
                }
            }
            foreach (var item in oreders)
            {
                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}

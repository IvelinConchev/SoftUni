using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            decimal totalPrice = 0;

            //string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%\.]*<(?<product>[A-Za-z]+)>[^|%$\.]*\|(?<quantity>\d+)\|[^$%|\.]*?(?<price>\d+.?\d*)\$";
           string pattern = @"^%(?<name>[A-Z]{1}[a-z]+)%[^|$%\.]*<(?<product>\w+)>[^|$%\.]*\|(?<quantity>\d+)\|[^|$%\.]*?(?<price>\d+\.?\d*)\$$";
            Regex regex = new Regex(pattern);

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);

                    if (quantity != 0)
                    {
                        decimal priceProduct = quantity * price;
                        totalPrice += priceProduct;
                        Console.WriteLine($"{name}: {product} - {priceProduct:f2}");

                    }

                }
            }
            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal totalPrice = 0;

             string pattern = @">>(?<name>[A-Z]+[a-z]*)<<(?<price>[\d]+.?\d*)!(?<quantity>[\d]+)";
           // string pattern = @">>(?<name>[A-Z]+[a-z]*)<<(?<price>[\d]+.?[0-9]*)!(?<quantity>[\d]+)";

            Regex regex = new Regex(pattern);

            int counter = 0;
            Console.WriteLine("Bought furniture: ");

            while (input != "Purchase")
            {
                Match matches = regex.Match(input);

                

                if (matches.Success)
                {
                    string name = matches.Groups["name"].Value;
                    decimal price = decimal.Parse(matches.Groups["price"].Value);
                    int quantity = int.Parse(matches.Groups["quantity"].Value);

                    totalPrice += price * quantity;

                    Console.WriteLine(name);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}

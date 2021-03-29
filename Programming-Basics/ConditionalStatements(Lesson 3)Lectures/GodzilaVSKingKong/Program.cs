using System;

namespace GodzilaVSKingKong
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int numberPeoples = int.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());

            decimal priceDekor = budget * 10 / 100;
            decimal priceClothTotal = numberPeoples * price;
            if (numberPeoples > 150)
            {
                priceClothTotal = priceClothTotal * 0.9m;
            }
            decimal totalPrice = priceDekor + priceClothTotal;
            if (budget >= totalPrice)
            {
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with {0:f2} leva left.",
                    Math.Abs(budget - totalPrice));
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs {0:0.00} leva more.", 
                    Math.Abs(budget - totalPrice));
            }
        }
    }
}

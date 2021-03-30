using System;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetOfMovie = double.Parse(Console.ReadLine());
            int numberStatists = int.Parse(Console.ReadLine());
            double clothing = double.Parse(Console.ReadLine());
            double discount = 0.0;
            //double fullBudget = 0;

            double decor = budgetOfMovie * 0.1;
            double sumClothing = numberStatists * clothing;

            if (numberStatists > 150)
            {
                discount = sumClothing * 0.1;
                 sumClothing = sumClothing - discount;
                //double fullCloth = discount - discountCloth;
            }

            double fullBudget = decor + sumClothing;
            // double sum = budgetOfMovie - fullBudget;
            if (fullBudget > budgetOfMovie)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs {0:f2} leva more.", Math.Abs(budgetOfMovie - fullBudget));
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with {0:f2} leva left.",
                    budgetOfMovie - fullBudget);
            }
        }
    }
}

using System;

namespace _05._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());

            double rent = 0.0;
            //double rent = 0.0;

            if (season == "Spring")
            {
                rent = 3000;
            }
            else if (season == "Summer")
            {
                rent = 4200;
            }
            else if (season == "Autumn")
            {
                rent = 4200;
            }
            else if (season == "Winter")
            {
                rent = 2600;
            }
            if (fisherman <= 6)
            {
                rent -= rent * 0.10;
            }
            else if (fisherman >= 7 && fisherman <= 11)
            {
                rent -= rent * 0.15;
            }
            else if (fisherman > 12)
            {
                rent -= rent * 0.25;
            }
            if (fisherman % 2 == 0 && season != "Autumn")
            {
                rent -= rent * 0.05;
            }

            double money = Math.Abs(rent - budget);

            if (budget >= rent)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", money);
            }

            else if (rent > budget)
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", money);
            }

        }
    }
}

using System;

namespace _03._World_Snooker_Championship
{
    class Program
    {
        static void Main(string[] args)
        {
            string stageChampion = Console.ReadLine();
            string speciesTickets = Console.ReadLine();
            int numberTickets = int.Parse(Console.ReadLine());
            string pictureWithWin = Console.ReadLine();
            double price = 0.0;
            double finalDisc = 0.0;

            if (stageChampion == "Quarter final")
            {
                if (speciesTickets == "Standard")
                {
                    price = 55.50;
                }
                else if (speciesTickets == "Premium")
                {
                    price = 105.20;
                }
                else
                {
                    price = 118.90;
                }
            }
            else if (stageChampion == "Semi final")
            {
                if (speciesTickets == "Standart")
                {
                    price = 75.88;
                }
                else if (speciesTickets == "Premium")
                {
                    price = 125.22;
                }
                else
                {
                    price = 300.40;
                }
            }
            else if (stageChampion == "Final")
            {
                if (speciesTickets == "Standart")
                {
                    price = 110.10;
                }
                else if (speciesTickets == "Premium")
                {
                    price = 160.66;
                }
                else
                {
                    price = 400;
                }
            }

            double priceTicket = numberTickets * price;

            if (priceTicket > 4000 && pictureWithWin == "Y")
            {
                double discount = priceTicket * 0.75;
                finalDisc = priceTicket - discount;
                Console.WriteLine($"{finalDisc:f2}");
            }
            else if (priceTicket > 2500)
            {
                double discount = priceTicket * 0.10;
                finalDisc = priceTicket - discount;
                double bb = numberTickets * 40;
                double finalSum = finalDisc + bb;
                Console.WriteLine($"{finalSum:f2}");
            }
            // if (pictureWithWin == "Y")
            //{
            //    double bb = numberTickets * 40;
            //    double finalSum = finalDisc + bb;
            //    Console.WriteLine($"{finalSum:f2}");
            //}
            else
            {
                Console.WriteLine($"{priceTicket:f2} ");
            }
        }
    }
}

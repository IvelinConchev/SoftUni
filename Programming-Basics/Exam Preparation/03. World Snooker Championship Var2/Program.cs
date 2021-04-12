using System;

namespace _03._World_Snooker_Championship_Var2
{
    class Program
    {
        static void Main(string[] args)
        {
            string stageChampion = Console.ReadLine();
            string speciesTickets = Console.ReadLine();
            int numberTickets = int.Parse(Console.ReadLine());
            string pictureWithWin = Console.ReadLine();

            double ticketPrice = 0;
            double priceWithDiscount = 0;
            double priceperpicture = 0;

            if (stageChampion == "Quarter final" && speciesTickets == "Standard")
            {
                ticketPrice = numberTickets * 55.5;
            }
            else if (stageChampion == "Semi final" && speciesTickets == "Standard")
            {
                ticketPrice = numberTickets * 75.88;
            }
            else if (stageChampion == "Final" && speciesTickets == "Standard")
            {
                ticketPrice = numberTickets * 110.10;
            }
            else if (stageChampion == "Quarter final" && speciesTickets == "Premium")
            {
                ticketPrice = numberTickets * 105.20;
            }
            else if (stageChampion == "Semi final" && speciesTickets == "Premium" )
            {
                ticketPrice = numberTickets * 125.22;
            }
            else if (stageChampion == "Final" && speciesTickets == "Premium")
            {
                ticketPrice = numberTickets * 160.66;
            }
            else if (stageChampion == "Quarter final" && speciesTickets == "VIP")
            {
                ticketPrice = numberTickets * 118.90;
            }
            else if (stageChampion == "Semi final" && speciesTickets == "VIP")
            {
                ticketPrice = numberTickets * 300.40;
            }
            else if (stageChampion == "Final" && speciesTickets == "VIP")
            {
                ticketPrice = numberTickets * 400;
            }

            if (ticketPrice > 4000)
            {
                if (pictureWithWin == "Y" || pictureWithWin == "N")
                {
                    priceWithDiscount = ticketPrice * 0.75;
                    Console.WriteLine($"{priceWithDiscount:f2}");
                }
            }
            else if (ticketPrice <= 4000 && ticketPrice > 2500)
            {
                priceWithDiscount = ticketPrice * 0.9;
                if (pictureWithWin == "Y")
                {
                    priceperpicture = numberTickets * 40;
                    double sum = priceWithDiscount + priceperpicture;
                    Console.WriteLine($"{sum:f2}");
                }
                else
                {
                    Console.WriteLine($"{priceWithDiscount:f2}");
                }
            }
            else if (pictureWithWin == "N")
            {
                Console.WriteLine($"{ticketPrice:f2}");
            }
            else if (pictureWithWin == "Y")
            {
                priceperpicture = numberTickets * 40;
                Console.WriteLine($"{priceperpicture + ticketPrice:f2}");
            }
        }
    }
}

using System;

namespace _06._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    decimal destination = budget * 0.30m;
                    decimal full = budget - destination;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}", destination);
                }
                else
                {
                    decimal destination = budget * 0.70m;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:f2}", destination);
                }
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    decimal destination = budget * 0.40m;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}", destination);
                }
                else
                {
                    decimal destination = budget * 0.80m;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}", destination);
                }
            }
            else
            {
                decimal destination = budget * 0.90m;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", destination);
            }
        }
    }
}

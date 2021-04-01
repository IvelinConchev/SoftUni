using System;

namespace _02._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            int numderOfRows = int.Parse(Console.ReadLine());
            int numberOfColumn = int.Parse(Console.ReadLine());

            double fullSum = 0.0;

            if (typeProjection == "Premiere")
            {
                 fullSum = numderOfRows * numberOfColumn * 12;
            }
            else if (typeProjection == "Normal")
            {
                 fullSum = numderOfRows * numberOfColumn * 7.50;
            }
            else if (typeProjection == "Discount")
            {
                 fullSum = numderOfRows * numberOfColumn * 5.00;
            }
            Console.WriteLine($"{fullSum:f2} leva");

        }
    }
}

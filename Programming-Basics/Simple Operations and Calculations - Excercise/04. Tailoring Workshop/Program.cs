using System;

namespace _04._Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int table = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = table * (length + 2 * 0.30) * (height + 2 * 0.30);
            double fullArea = table * (length / 2) * (length / 2);
            double priceUsd = area * 7 + fullArea * 9;
            double priceBgn = priceUsd * 1.85;

            Console.WriteLine("{0:F2} USD", priceUsd);
            Console.WriteLine("{0:F2} BGN", priceBgn);

        }
    }
}

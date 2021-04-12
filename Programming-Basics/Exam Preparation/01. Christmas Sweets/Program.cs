using System;

namespace _01._Christmas_Sweets
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceBaklavaOfKg = double.Parse(Console.ReadLine());
            double priceMuffinsOfKg = double.Parse(Console.ReadLine());
            double KgTheCalf = double.Parse(Console.ReadLine());
            double KgTheCandy = double.Parse(Console.ReadLine());
            int KgBisquite = int.Parse(Console.ReadLine());

            double priceCalf = priceBaklavaOfKg + priceBaklavaOfKg * 0.60;
            double sumCalf = KgTheCalf * priceCalf;
            double priceCandy = priceMuffinsOfKg + priceMuffinsOfKg * 0.80;
            double sumCandy = KgTheCandy * priceCandy;
            double sumBisquite = KgBisquite * 7.5;
            double fullSum = sumCalf + sumCandy + sumBisquite;
            Console.WriteLine("{0:f2}", fullSum);
        }
    }
}

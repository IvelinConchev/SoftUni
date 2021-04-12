using System;

namespace _02._Christmas_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceSum = double.Parse(Console.ReadLine());
            int numberFentasyBook = int.Parse(Console.ReadLine());
            int numberHororBook = int.Parse(Console.ReadLine());
            int numberRomanceBook = int.Parse(Console.ReadLine());

            double sumDiscount = numberFentasyBook * 14.90 + numberHororBook * 9.80 + numberRomanceBook * 4.30;
            double percentDDS = sumDiscount * 0.20;
            double sumRentDDS = sumDiscount - percentDDS;

            if (sumRentDDS > priceSum)
            {
                double cell = sumRentDDS - priceSum;//
                double tenPercent = Math.Truncate(cell * 0.10);
                double sum = cell - tenPercent;
                double finishSum = sum + priceSum;
                Console.WriteLine($" {finishSum:f2} leva donated.");
                Console.WriteLine($"Sellers will receive {tenPercent} leva.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(sumRentDDS - priceSum):f2} money needed.");
            }
        }
    }
}

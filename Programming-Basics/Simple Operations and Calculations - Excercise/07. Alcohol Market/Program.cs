using System;

namespace _07._Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerLitre = double.Parse(Console.ReadLine());
            double wineLitre = double.Parse(Console.ReadLine());
            double rakiaLitre = double.Parse(Console.ReadLine());
            double whiskeyLitre = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2;
            double winePrice = rakiaPrice - (0.4 * rakiaPrice);
            double beerPrice = rakiaPrice - (0.8 * rakiaPrice);
            double sumRakia = rakiaLitre * rakiaPrice;
            double sumWine = wineLitre * winePrice;
            double sumBeer = beerPrice * beerLitre;
            double sumWhiskey = whiskeyLitre * whiskeyPrice;
            double fullSum = sumRakia + sumWine + sumBeer + sumWhiskey;

            Console.WriteLine("{0:F2}", fullSum);

        }
    }
}

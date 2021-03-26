using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int confectioner = int.Parse(Console.ReadLine());
            int cake = int.Parse(Console.ReadLine());
            int corrugation = int.Parse(Console.ReadLine());
            int pancake = int.Parse(Console.ReadLine());

            double cakeToDay = cake * 45;
            double corrugationToDay = corrugation * 5.80;
            double pancakeToDay = pancake * 3.20;

            double fullSumToDay = (cakeToDay + corrugationToDay + pancakeToDay) * confectioner;
            double fullSum = fullSumToDay * day;

            double  cost = (fullSum - fullSum / 8) ;           
            
            Console.WriteLine("{0:F2}", cost);
        }
    }
}

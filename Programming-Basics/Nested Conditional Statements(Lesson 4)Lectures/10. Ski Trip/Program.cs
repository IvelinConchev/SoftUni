using System;

namespace _10._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayStay = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string evaluation = Console.ReadLine();
            decimal price = 0;
            decimal discount = 0;

            if (typeOfRoom == "room for one person")
            {
                price = price * 18.00m;
                if (dayStay < 10)
                {
                    discount = 0;
                }
                else if (dayStay > 10 && dayStay < 15)
                {
                    discount = 0;
                }
                else
                {
                    discount = 0;
                }
            }
            else if (typeOfRoom == "apartment")
            {
                price = price * 25.00m;
                if (dayStay < 10)
                {
                    discount = discount * price * 0.3m;
                }
                else if (dayStay > 10 && dayStay < 15)
                {
                    discount = discount * price * 0.35m;
                }
                else
                {
                    discount = discount * price * 0.50m;
                }
            }
            else
            {
                price = price * 35.00m;
                if (dayStay < 10)
                {
                    discount = discount * price * 0.10m;
                }
                else if (dayStay > 10 && dayStay < 15)
                {
                    discount = discount * price * 0.15m;
                }
                else
                {
                    discount = discount * price * 0.20m;
                }
            }
        }
    }
}

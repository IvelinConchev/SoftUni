using System;

namespace _10._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine();
            int numberHoliday = int.Parse(Console.ReadLine());
            int numberWeekends = int.Parse(Console.ReadLine());

            double volleyHolidays = numberHoliday * (2.0 / 3);
            double volleyCountry = numberWeekends;
            double volleyWeekends = (48 - numberWeekends) * (3.0 / 4);
            double totalgames = volleyHolidays + volleyCountry + volleyWeekends;
            if (typeYear == "leap")
            {
                totalgames = totalgames + totalgames * 0.15;
                Console.WriteLine(Math.Floor(totalgames));
            }
            else
            {
                Console.WriteLine(Math.Floor(totalgames));
            }
        }
    }
}

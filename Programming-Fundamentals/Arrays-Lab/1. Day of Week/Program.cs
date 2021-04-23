using System;

namespace _1._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[]
            {"Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"};

            int dayNumbers = int.Parse(Console.ReadLine());

            if (dayNumbers >= 1 && dayNumbers <= 7)
            {
                string day = days[dayNumbers - 1];
                //Console.WriteLine(days[dayNumbers - 1]);
                Console.WriteLine(day);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}

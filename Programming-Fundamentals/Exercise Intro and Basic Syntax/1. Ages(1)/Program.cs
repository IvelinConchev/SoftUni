using System;

namespace _1._Ages_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string years = string.Empty;

            if (age >= 0 && age <= 2)
            {
                years = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                years = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                years = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                years = "adult";
            }
            else
            {
                years = "elder";
            }
            Console.WriteLine(years);
        }
    }
}

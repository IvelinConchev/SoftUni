using System;

namespace _08._Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomeToLeva = double.Parse(Console.ReadLine());
            double averageGreat = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());


            if (incomeToLeva > minimalSalary)
            {
                if (averageGreat < 5.50)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
            else if (incomeToLeva < minimalSalary && averageGreat > 4.50)
            {
                double scholarship = minimalSalary * 0.35;
                Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(scholarship));

                if (averageGreat > 5.50)
                {
                    double scholashipExcellent = averageGreat * 25;


                     if (scholarship > scholashipExcellent)
                    {
                        Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(scholashipExcellent));
                    }
                }
            }
        }
    }
}


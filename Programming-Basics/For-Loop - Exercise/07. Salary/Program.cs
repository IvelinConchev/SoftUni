using System;

namespace _07._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOpenTab = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOpenTab; i++)
            {
                string numberNameWeb = Console.ReadLine();

                if (numberNameWeb == "Facebook")
                {
                    salary =  salary - 150;
                }
                else if (numberNameWeb == "Instagram")
                {
                     salary = salary - 100;
                }
                else if (numberNameWeb == "Reddit")
                {
                     salary = salary - 50;
                }

                if (salary <= 0)
                {
                    break;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}

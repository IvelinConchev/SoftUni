using System;

namespace Stipendii
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal income = decimal.Parse(Console.ReadLine());
            decimal averageGrades = decimal.Parse(Console.ReadLine());
            decimal minimumSalary = decimal.Parse(Console.ReadLine());

            decimal socialScholarship = 0;
            decimal excellentScholarship = 0;

            if (averageGrades > 4.5m)
            {
                if (income < minimumSalary)
                {
                    // have right to get social...
                    socialScholarship = Math.Floor(minimumSalary * 35 / 100);
                }
                if (averageGrades >= 5.5m)
                {
                    // have right to get excellent...
                    excellentScholarship = Math.Floor(averageGrades * 25);
                    if (socialScholarship > 0)
                    {
                        // have right for both of them.
                        if (excellentScholarship >= socialScholarship)
                        {
                            Console.WriteLine("You get a scholarship for excellent results {0} BGN",
                            excellentScholarship);
                        }
                        else
                        {
                            Console.WriteLine("You get a Social scholarship {0} BGN",
                                                       socialScholarship);
                        }
                    }
                    else
                    {
                        // no right to get social.
                        Console.WriteLine("You get a scholarship for excellent results {0} BGN",
                            excellentScholarship);
                    }
                }
                else
                {
                    // no right to get excellent.
                    if (socialScholarship > 0)
                    {
                        Console.WriteLine("You get a Social scholarship {0} BGN",
                            socialScholarship);
                    }
                    else
                    {
                        // no right to get any of them.
                        Console.WriteLine("You cannot get a scholarship!");
                    }
                }
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

        }
    }
}

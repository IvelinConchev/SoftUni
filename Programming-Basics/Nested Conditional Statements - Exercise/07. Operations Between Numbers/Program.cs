using System;

namespace _07._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string operators = Console.ReadLine();

            if (operators == "+")
            {
                double sum = N1 + N2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} + {1} = {2} - even", N1, N2, sum);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2} - odd", N1, N2, sum);
                }
            }
            else if (operators == "-")
            {
                double diff = N1 - N2;
                if (diff % 2 == 0)
                {
                    Console.WriteLine("{0} - {1} = {2} - even", N1, N2, diff);
                }
                else
                {
                    Console.WriteLine("{0} - {1} = {2} - odd", N1, N2, diff);
                }
            }
            else if (operators == "*")
            {
                double multi = N1 * N2;
                if (multi % 2 == 0)
                {
                    Console.WriteLine("{0} * {1} = {2} - even", N1, N2, multi);
                }
                else
                {
                    Console.WriteLine("{0} * {1} = {2} - odd", N1, N2, multi);
                }
            }
            else if (operators == "/")
            {
                double del = N1 / N2;
                if (N2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
                else
                {
                    Console.WriteLine("{0} / {1} = {2:f2} ", N1, N2, del);
                }
            }
            else if (operators == "%")
            {
                double del = N1 % N2;
                if (N2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
                else
                {
                    Console.WriteLine("{0} % {1} = {2} ", N1, N2, del);
                }
            }
        }
    }
}

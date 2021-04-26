using System;

namespace _8._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int degree = int.Parse(Console.ReadLine());
            PrintMathPower(number, degree);
        }

        static double PrintMathPower(double number, int degree)
        {
            double result = 0;
            result = Math.Pow(number, degree);
            Console.WriteLine(result);

            return result;
        }
    }
}

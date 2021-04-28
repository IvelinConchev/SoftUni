using System;

namespace _8._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

           double result = PrintFactorialFirstNumber(firstNumber, secondNumber);
            double resultTwo = PrintFactorialSecondNumbers(firstNumber, secondNumber);
            double totalResul = PrintFactorialFirstNumber(firstNumber, secondNumber) /
                PrintFactorialSecondNumbers(firstNumber, secondNumber);
            Console.WriteLine($"{totalResul:f2}");
        }

        private static double PrintFactorialSecondNumbers(int firstNumber, int secondNumber)
        {
            double factorial = 1;
            for (int counter = 1; counter <= secondNumber; counter++)
            {
                factorial = factorial * counter;
            }
            return factorial;
        }

        private static double PrintFactorialFirstNumber(double firstNumber, double secondNumber)
        {
            double factorial = 1;
            for (int counter = 1; counter <= firstNumber; counter++)
            {
                factorial = factorial * counter;
            }
            return factorial;
        }
    }
}

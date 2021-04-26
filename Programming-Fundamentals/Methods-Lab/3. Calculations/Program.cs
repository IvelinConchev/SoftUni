using System;

namespace _3._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            double firstNumber = int.Parse(Console.ReadLine());
            double secondNumber = int.Parse(Console.ReadLine());
            if (word == "add")
            {
                Add(firstNumber, secondNumber);
            }
            else if (word == "multiply")
            {
                Multiply(firstNumber, secondNumber);
            }
            else if (word == "subtract")
            {
                Subtract(firstNumber, secondNumber);
            }
            else
            {
            Divide(firstNumber, secondNumber);
            }

        }

        static void Add(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            Console.WriteLine(result);
        }

        static void Multiply(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            Console.WriteLine(result);
        }

        static void Subtract(double firstNumber, double secondNumber)
        {
            double result = Math.Abs(firstNumber - secondNumber);
            Console.WriteLine(result);
        }

        static void Divide(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            Console.WriteLine(result);
        }

    }
}

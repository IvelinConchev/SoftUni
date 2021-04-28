using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());

            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int result = Substract(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(result);

        }
        static int Sum(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }
        static int Substract(int firstNumber, int secondNumber, int thirdNumber)
        {
            int sumToDigits = Sum(firstNumber, secondNumber);
            int result = (sumToDigits - thirdNumber);
            return result;
        }

    }
}

using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = PrintSmallestNumbers(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(result);
        }

        static int PrintSmallestNumbers(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                return firstNumber;
            }
            else if (secondNumber < thirdNumber && secondNumber < firstNumber)
            {
                return secondNumber;
            }
            else 
            {
                return thirdNumber;
            }
            
        }
    }
}

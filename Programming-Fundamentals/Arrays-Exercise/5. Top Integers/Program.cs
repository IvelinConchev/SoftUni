using System;
using System.Linq;

namespace _5._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool isBigger = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumbers = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int num = numbers[j];
                    if (num >= currentNumbers) 
                    {
                        isBigger = false;
                        break;
                    }
                }
                if (isBigger == true)
                {
                    Console.Write(currentNumbers + " ");
                }
                isBigger = true;
            }

            
        }
    }
}

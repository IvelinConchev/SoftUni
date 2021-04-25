using System;

namespace _4._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine()
                .Split();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string elementToRotate = numbers[0];

                for (int j = 1; j < numbers.Length; j++)
                {
                    string currentElement = numbers[j];
                    numbers[j - 1] = currentElement;
                    numbers[numbers.Length - 1] = elementToRotate;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

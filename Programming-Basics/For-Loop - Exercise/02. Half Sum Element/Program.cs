using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxElememt = int.MinValue;
            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
                if (num > maxElememt)
                {
                    maxElememt = num;
                }
            }
            int sumWithoutMaxNumber = sum - maxElememt;
            if (maxElememt == sumWithoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxElememt);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(maxElememt - sumWithoutMaxNumber));
            }
        }
    }
}

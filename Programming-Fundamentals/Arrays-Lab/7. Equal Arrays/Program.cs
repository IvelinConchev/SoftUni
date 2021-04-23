using System;
using System.Linq;

namespace _7._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firrstArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] secondArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int indexFirst = 0;
            int indexSecond = 0;
            int sum = 0;
            int counter = 0;

            for (int i = 0; i < firrstArray.Length; i++)
            {
                indexFirst = firrstArray[i];
                //}

                for (int j = 0; j < secondArray.Length; j++)
                {
                    indexSecond = secondArray[j];

                    if (indexFirst == indexSecond)
                    {
                        sum += indexFirst;
                    }
                    else
                    {
                        counter++;

                    }
                }
            }
            if (sum > 0)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical.Found difference at {counter} index");
            }
        }
    }
}

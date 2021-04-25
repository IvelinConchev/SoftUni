using System;

namespace _3._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] firstArray = new string[n];
            string[] secondArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] numbers = Console.ReadLine().Split();

                string indexZero = numbers[0];
                string indexOne = numbers[1];

                if (i % 2 == 0)
                {
                    firstArray[i] = indexZero;
                    secondArray[i] = indexOne;
                }
                else if (i % 2 == 1)
                {
                    secondArray[i] = indexZero;
                    firstArray[i] = indexOne;
                }
                
            }
            //foreach (string item in firstArray)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //foreach (string items in secondArray)
            //{
            //    Console.Write(items + " ");
            //}
            Console.WriteLine(string.Join(" ",firstArray));
            Console.WriteLine(string.Join(" ",secondArray));
        }
    }
}

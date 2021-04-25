using System;
using System.Linq;

namespace _7._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1, tempCount = 1, number = 0;

            //Console.Write("Enter array length: ");
            //int length = Int32.Parse(Console.ReadLine());
            //int[] arr = new int[length];
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                //Console.Write("Enter {0} element: ", i);
                //arr[i] = Int32.Parse(Console.ReadLine());


                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[i] == arr[j + 1])
                    {
                        tempCount++;
                    }
                    else
                    {
                        tempCount = 1;
                       // break;
                    }

                    if (tempCount > count)
                    {
                        count = tempCount;
                        number = arr[i];
                    }
                }

            }
                for (int k = 0; k < count; k++)
            {

                Console.Write($"{number + " "}");
            }
        }
    }
}

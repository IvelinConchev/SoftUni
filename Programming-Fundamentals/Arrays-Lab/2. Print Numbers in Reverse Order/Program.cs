using System;
using System.Linq;

namespace _2._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] numbers = new string[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Console.ReadLine();
            }

            //Array.Reverse(numbers);
            //Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(string.Join(" ",numbers.Reverse()));
        }
    }
}

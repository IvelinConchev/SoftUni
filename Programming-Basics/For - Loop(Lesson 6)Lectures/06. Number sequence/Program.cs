using System;

namespace _06._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int smallest = int.MaxValue;
            int biggest = int.MinValue;

            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < smallest)
                {
                    smallest = num;
                }
                if (num > biggest)
                {
                    biggest = num;
                }
            }
            Console.WriteLine("Max number: {0}", biggest);
            Console.WriteLine("Min number: {0}", smallest);
        }
    }
}

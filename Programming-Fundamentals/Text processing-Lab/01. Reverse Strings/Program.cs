using System;
using System.Linq;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string reverse = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                    reverse = string.Empty;
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverse += input[i];
                }
                Console.WriteLine($"{input} = {reverse}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split("|",StringSplitOptions.RemoveEmptyEntries).ToList();

            numbers.Reverse();

            List<string> result = new List<string>();

            foreach (string currentNumber in numbers)
            {
                string[] items = currentNumber
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in items)
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

using System;
using System.Linq;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(n => n.Length % 2 == 0)
                .ToArray();
            foreach (var item in words)
            {
                // Console.Write(string.Join(" ", item,Environment.NewLine));
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] words = Console.ReadLine().ToCharArray();
            Dictionary<char, int> numbers = new Dictionary<char, int>();

            foreach (var letter in words)
            {
                if (letter != ' ')
                {
                    if (!numbers.ContainsKey(letter))
                    {
                        numbers.Add(letter, 0);
                    }
                    numbers[letter]++;
                }
            }
            foreach (var item in numbers)
            {
                char currentKey = item.Key;
                int currentValue = item.Value;
                Console.WriteLine($"{currentKey} -> {currentValue}");
            }
        }
    }
}

using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine().ToLower();
            int counter = PrintVowelsCount(symbol);
            Console.WriteLine(counter);
        }

        static int PrintVowelsCount(string symbol)
        {
            int counter = 0;
            string result = string.Empty;
            for (int i = 0; i < symbol.Length; i++)
            {
                char currentChar = symbol[i];
                if (currentChar == 'a')
                {
                    counter++;
                }
                else if (currentChar == 'e')
                {
                    counter++;
                }
                else if (currentChar == 'i')
                {
                    counter++;
                }
                else if (currentChar == 'o')
                {
                    counter++;
                }
                else if (currentChar == 'u')
                {
                    counter++;
                }
                else if (currentChar == 'y')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}

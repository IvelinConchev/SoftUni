using System;

namespace _6._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string output = string.Empty;

            if (text.Length % 2 == 0)
            {
                 output = GetMiddleCharFromEvenStringLenght(text);
            }
            else
            {
                 output = GetMiddleCharFromOddStringLenght(text);
            }
            Console.WriteLine(output);
        }

        private static string GetMiddleCharFromOddStringLenght(string text)
        {
            int index = text.Length / 2;
            string chars = text.Substring(index, 1);
            return chars;
        }

        private static string GetMiddleCharFromEvenStringLenght(string text)
        {
            int index = text.Length / 2;
            string chars = text.Substring(index - 1, 2);
            return chars;
        }
    }
}

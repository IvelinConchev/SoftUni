using System;

namespace Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstCharacters = char.Parse(Console.ReadLine());
            char secondCharacters = char.Parse(Console.ReadLine());
            char thirdCharacters = char.Parse(Console.ReadLine());

            Console.WriteLine($"{thirdCharacters} {secondCharacters} {firstCharacters}");

        }
    }
}

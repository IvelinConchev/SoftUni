using System;
using System.Linq;

namespace _4._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] letters = Console.ReadLine().Split();

            for (int i = 0; i < letters.Length / 2; i++)
            {
                string oldElement = letters[i];
                letters[i] = letters[letters.Length - i - 1];
                letters[letters.Length - i - 1] = oldElement;
            }
            //for (int i = 0; i < letters.Length; i++)
            //{
            //    Console.Write(letters[i] + " ");
            //}
            foreach (var letter in letters)
            {
                Console.Write(letter + " ");
            }
            //Console.WriteLine(string.Join(' ', Console.ReadLine()
            //    .Split()
            //    .Reverse()));

        }
    }
}

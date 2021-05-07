using System;

namespace _03._Substring_OtherVar_
{
    class Program
    {
        static void Main(string[] args)
        {
            string textToRemove = Console.ReadLine().ToLower();
            string word = Console.ReadLine();

            if (word.Contains(textToRemove))
            {
                int startIndex = word.IndexOf(textToRemove);
               word = word.Remove(startIndex, textToRemove.Length);
            }
            Console.WriteLine(word);
        }
    }
}

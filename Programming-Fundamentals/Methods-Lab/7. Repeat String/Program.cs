using System;

namespace _7._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());
            word = PrintWords(word,counter);
            
           //Console.WriteLine(word);
        }

        static string PrintWords(string word, int counter)
        {
            word = new String(word);
            for(int i = 0; i < counter; i++)
            {
                Console.Write(word);
            }
            return word;
        }
    }
}

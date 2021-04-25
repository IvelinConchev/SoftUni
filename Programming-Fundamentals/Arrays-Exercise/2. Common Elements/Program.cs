using System;

namespace _2._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray= Console.ReadLine()
                .Split();
            string[] secondtArray = Console.ReadLine()
                .Split();

            for (int i = 0; i < secondtArray.Length; i++)
            {
                string secondWord = secondtArray[i];
                for (int j = 0; j < firstArray.Length; j++)
                {
                    string firstWord = firstArray[j];

                    if (secondWord == firstWord)
                    {
                       // Console.WriteLine($"{secondtArray[i]}");
                        Console.Write(string.Join(" ",secondWord + " "));
                    }
                }
            }
        }
    }
}

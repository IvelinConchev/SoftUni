using System;

namespace _02._Repeat_Strings_OtherVar_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                string result = words[i];
                for (int j = 0; j < result.Length; j++)
                {
                    Console.Write(result);
                }
            }
        }
    }
}

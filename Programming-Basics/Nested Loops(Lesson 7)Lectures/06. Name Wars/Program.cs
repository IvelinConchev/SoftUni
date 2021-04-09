using System;

namespace _06._Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string winnerName = "";
            int winnerSum = 0;

            while (name != "STOP")
            {
                int length = name.Length;
                int sum = 0;
                for (int i = 0; i < length; i++)
                {
                    sum = sum + (int)name[i];
                }
                if (sum > winnerSum)
                {
                    winnerSum = sum;
                    winnerName = name;
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {winnerName} - {winnerSum}!");
        }
    }
}

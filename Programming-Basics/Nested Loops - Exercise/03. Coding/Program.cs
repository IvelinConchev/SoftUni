using System;

namespace _03._Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();


            for (int i = number.Length - 1; i >= 0; i--)
            {
                char currentDigit = number[i];
                int currenDigitToNumber = int.Parse(currentDigit.ToString());
                //Console.WriteLine(currenDigitToNumber);
                if (currenDigitToNumber == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }

                for (int n = 1; n <= currenDigitToNumber; n++)
                {
                    Console.Write((char)(currenDigitToNumber + 33));
                }
                Console.WriteLine();
            }
        }
    }
}


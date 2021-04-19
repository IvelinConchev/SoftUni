using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            //int takova = 0;
            //bool toe = false;
            for (int ch = 1; ch <= numbers; ch++)
            {
                int sum = 0;
                int digit = ch;
                while (digit > 0)
                {
                    sum += digit % 10;
                    digit = digit / 10;
                }
                bool specialNumbers = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", ch, specialNumbers);
                // obshto = 0;
                // ch = takova;
            }

        }

    }

}


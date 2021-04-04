using System;

namespace _05._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currentMax = int.MinValue;
            while (n > 0 )
            {
                int nextNum = int.Parse(Console.ReadLine());
                if (nextNum > currentMax)
                {
                    currentMax = nextNum;
                }
                n--;
            }
            Console.WriteLine(currentMax );
        }
    }
}

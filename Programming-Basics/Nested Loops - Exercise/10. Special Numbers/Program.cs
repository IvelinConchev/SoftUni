using System;

namespace _10._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int m = 1; m <= 9; m++)
                        {
                            if (numN % i == 0 && numN % j == 0 && numN % k == 0 && numN % m == 0)
                            {
                                Console.WriteLine("{0}{1}{2}{3} ", i, j, k, m);
                            }
                        }
                    }
                }
            }
        }
    }
}

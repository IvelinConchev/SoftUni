using System;

namespace _05._Equal_Sums_Left_Right_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            for (int i = startNum; i <= endNum; i++)
            {
                int digit5 = i % 10;
                int digit4 = i / 10 % 10;
                int digit3 = i / 100 % 10;
                int digit2 = i / 1000 % 10;
                int digit1 = i / 10000 % 10;

                if (digit5 + digit4 == digit2 + digit1)
                {
                    Console.Write(i + " ");
                }
                else if (digit5 + digit4 > digit2 + digit1)
                {
                    if (digit2 + digit1 + digit3 == digit5 + digit4)
                    {
                        Console.Write(i + " ");
                    }
                }
                else if (digit5 + digit4 < digit2 + digit1)
                {
                    if (digit2 + digit1 == digit5 + digit4 + digit3)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

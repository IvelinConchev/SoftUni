using System;

namespace _02._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isBigger = false;
            int number = int.Parse(Console.ReadLine());
            int counter = 1;
            for (int row = 1; row <= number; row++)
            {
                for (int cols = 1; cols <= row; cols++)
                {
                    Console.Write(counter++ + " ");
                    if (counter == number + 1)
                    {
                        isBigger = true;
                        break;
                    }
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

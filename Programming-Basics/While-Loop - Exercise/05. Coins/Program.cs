using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double rest = input * 100;

            int counter = 0;
            while (rest >= 1)
            {
                if (rest - 200 >= 0)
                {
                    rest -= 200;
                    counter++;
                }
                else if (rest - 100 >= 0)
                {
                    rest -= 100;
                    counter++;
                }
                else if (rest - 50 >= 0)
                {
                    rest -= 50;
                    counter++;
                }
                else if (rest - 20 >= 0)
                {
                    rest -= 20;
                    counter++;
                }
                else if (rest - 10 >= 0)
                {
                    rest -= 10;
                    counter++;
                }
                else if (rest - 5 >= 0)
                {
                    rest -= 5;
                    counter++;
                }
                else if (rest - 2 >= 0)
                {
                    rest -= 2;
                    counter++;
                }
                else if (rest - 1 >= 0)
                {
                    rest -= 1;
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}

using System;

namespace _11._Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 0; i <= number; i+=2)
            {
                // Console.WriteLine(Math.Pow(2,i));
                Console.WriteLine(num);
                num = num * 2 * 2;
            }
        }
    }
}

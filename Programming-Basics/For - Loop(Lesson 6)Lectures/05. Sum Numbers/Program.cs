 using System;

namespace _05._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
                
            }
            Console.WriteLine(sum);
        }
    }
}

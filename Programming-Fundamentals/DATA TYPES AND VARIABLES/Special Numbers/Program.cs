using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            for (int num = 1; num <= numbers; num++)
            {
                int sum = 0;
                int digit = num;
                while (digit > 0)
                {
                    int seper = digit % 10;
                    sum += seper;
                    digit /= 10;

                }
                bool specialNumber = (sum == 5) || (sum == 7) || (sum == 11);
                
                Console.WriteLine($"{num} -> {specialNumber} ");
            }

        }
    }
}

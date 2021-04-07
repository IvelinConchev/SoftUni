using System;

namespace _08._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int oddNumber = 0;
            int evenNumber = 0;
            for (int position = 1; position <= number; position++)
            {
                int num = int.Parse(Console.ReadLine());
                if (position % 2 == 0)
                {
                    evenNumber = evenNumber + num;
                }
                else
                {
                    oddNumber = oddNumber + num;
                }
            }
            if (evenNumber == oddNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", evenNumber);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(evenNumber - oddNumber));
            }
        }
    }
}

using System;

namespace _07._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int leftSum = 0;
            for (int i = 1; i <= number; i++)
            {
                int num = int.Parse(Console.ReadLine());
                leftSum = leftSum + num;
            }
            int rightSum = 0;
            for (int i = 1; i <= number; i++)
            {
                int num = int.Parse(Console.ReadLine());
                rightSum = rightSum + num;
            }
            if (rightSum == leftSum)
            {
                Console.WriteLine("Yes, sum = {0}", rightSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(rightSum - leftSum));
            }
        }
    }
}

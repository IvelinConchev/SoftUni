using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numbers = int.Parse(Console.ReadLine());
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                int numbers = int.Parse(command);

                string result = IsPalindrom(numbers).ToString().ToLower();
                Console.WriteLine(result);
            }
        }

        static bool IsPalindrom(int numbers)
        {
            int palindrome = 0;
            int sum = 0;

            int temp = numbers;
            while (numbers > 0)
            {
                palindrome = numbers % 10;
                sum = (sum * 10) + palindrome;
                numbers = numbers / 10;
            }
            if (temp == sum)
            {
                return true;
            }
            return false;
        }
    }
}

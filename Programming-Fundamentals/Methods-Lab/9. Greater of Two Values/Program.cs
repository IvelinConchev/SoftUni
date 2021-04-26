using System;

namespace _9._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstText = Console.ReadLine();
            string secondText = Console.ReadLine();
            var result = GetMax(type, firstText, secondText);

        }

        static string GetMax(string type, string firstText, string secondText)
        {
            int resultOne = 0;
            int resulTwo = 0;
            if (type == "int")
            {
                resultOne = int.Parse(firstText);
                resultOne = int.Parse(firstText);
            }
            else if (type == "char")
            {
                resultOne = char.Parse(Console.ReadLine());
                resultOne = char.Parse(Console.ReadLine());
            }
            else if (type == "string")
            {
                int comparison = firstText.CompareTo(secondText);
                if (comparison > 0)
                {
                    return firstText;
                }
                else
                {
                    return secondText;
                }
            }
            if (resultOne > resulTwo)
            {
                return firstText;
            }
            else
            {
                return secondText;
            }
        }
    }
}

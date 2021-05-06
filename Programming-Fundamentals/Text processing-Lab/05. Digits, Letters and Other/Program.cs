using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultDigit = string.Empty;
            string resultLetter = string.Empty;
            string resultOther = string.Empty;

            string text = Console.ReadLine();

            foreach (var symbol in text)
            {
                if (char.IsDigit(symbol))
                {
                    resultDigit += symbol;
                }
                else if (char.IsLetter(symbol))
                {
                    resultLetter += symbol;
                }
                else
                {
                    resultOther += symbol;
                }
            }
            Console.WriteLine(resultDigit);
            Console.WriteLine(resultLetter);
            Console.WriteLine(resultOther);
        }
    }
}

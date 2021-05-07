using System;
using System.Text;

namespace _05._Digits__Letters_and_Other_OtherVer_
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder otherSymbol = new StringBuilder();

            foreach (var symbol in text)
            {
                if (char.IsDigit(symbol))
                {
                    digits.Append(symbol);
                }
                else if (char.IsLetter(symbol))
                {
                    letters.Append(symbol);
                }
                else
                {
                    otherSymbol.Append(symbol);
                }
            }
            Console.WriteLine($"{digits}\n{letters}\n{otherSymbol}\n");
            //Console.WriteLine(digits);
            //Console.WriteLine(letters);
            //Console.WriteLine(otherSymbol);

        }
    }
}

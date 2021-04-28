using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbolFirst = char.Parse(Console.ReadLine());
            char symbolSecond = char.Parse(Console.ReadLine());
            PrintSymbolAscII(symbolFirst, symbolSecond);


        }

        static void PrintSymbolAscII(char symbolFirst, char symbolSecond)
        {
            if (symbolFirst > symbolSecond)
            {
                char currentSymbol = symbolFirst;
                symbolFirst = symbolSecond;
                symbolSecond = currentSymbol;
            }
            for (int i = symbolFirst + 1; i < symbolSecond; i++)
            {
               
                Console.Write((char)i + " ");
            }
        }
    }
}

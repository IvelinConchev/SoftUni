using System;

namespace _5._Print_Part_of_the_ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSymbol = int.Parse(Console.ReadLine());
            int secondSymbol = int.Parse(Console.ReadLine());


            for (int i = firstSymbol; i <= secondSymbol; i++)
            {
                Console.Write((char)i + " ");
            }
            
        }
    }
}

using System;

namespace _09._Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int one = 1; one < n; one++)
            {
                for (int two = 1; two < n; two++)
                {
                    for (int three = 'a'; three <= 'a' + l; three++)
                    {
                        for (int four = 'a'; four < 'a' + l; four++)
                        {
                            int startFiveSymbol = Math.Max(one, two) + 1;
                            for (int five = startFiveSymbol; five <= n; five++)
                            {
                                Console.WriteLine($"{one}{two}{(char)three}{(char)four}{five} ");
                            }
                        }
                    }
                }
            }
        }
    }
}

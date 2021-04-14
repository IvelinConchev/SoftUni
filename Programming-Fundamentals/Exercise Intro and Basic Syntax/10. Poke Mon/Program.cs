using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int l = n;
            int counter = 0;

            while (l >= m)
            {
                l -= m;
                counter++;
                if (n /2 == m)
                {
                    l /= y;
                }
            }
            Console.WriteLine(l);
            Console.WriteLine(counter);
        }
    }
}

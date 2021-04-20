using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int piece = 0;
            int drops = 0;
            int dayCount = 0;
            int sum = 0;

            while (yield >= 100)
            {
                piece = yield - 26;
                yield = yield - 10;
                sum += piece;
                if (yield < 100)
                {
                    sum -= 26;

                }
                //drops -
                dayCount++;
            }
            Console.WriteLine(dayCount);
            Console.WriteLine(sum);
        }
    }
}

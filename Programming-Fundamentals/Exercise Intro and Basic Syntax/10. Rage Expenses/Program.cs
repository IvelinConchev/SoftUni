using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostgGamesCount = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());
            decimal headset = 0;
            decimal mouse = 0;
            decimal keyboard = 0;
            decimal display = 0;
            decimal expenses = 0;
            int count = 0;


            for (int i = 1; i <= lostgGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    headset += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    mouse += mousePrice;
                }
                //if (i % 2 == 0 && i % 3 == 0)
                if (i % 6 == 0)
                {
                    keyboard += keyboardPrice;
                    count++;
                    if (count % 2 == 0)
                    {
                        display += displayPrice;
                    }
                }
            }
            expenses = headset + mouse + keyboard + display;
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}

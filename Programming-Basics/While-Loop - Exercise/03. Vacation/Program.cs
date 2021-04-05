using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeedForHoliday = int.Parse(Console.ReadLine());
            double cashMoney = double.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendingCounter = 0;

            while (cashMoney < moneyNeedForHoliday && spendingCounter < 5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;

                if (command == "save")
                {
                    cashMoney = cashMoney + money;
                    spendingCounter = 0;
                }
                else if (command == "spend")
                {
                    cashMoney -= money;
                    spendingCounter += 1;
                    if (cashMoney < 0)
                    {
                        cashMoney = 0;
                    }
                }
            }

                if (spendingCounter == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(daysCounter);
                }
                if (cashMoney >= moneyNeedForHoliday)
                {
                    Console.WriteLine($"You saved the money for {daysCounter} days.");
                }
            }
        }
    }

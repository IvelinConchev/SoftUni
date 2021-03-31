using System;

namespace _09._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            decimal volumeSales = decimal.Parse(Console.ReadLine());
            decimal commission = 0;

            if (town == "Sofia")
            {
                if (0 <= volumeSales && volumeSales <= 500)
                {
                    commission = volumeSales * 5 / 100;
                }
                else if (volumeSales >= 501 && volumeSales <= 1000)
                {
                    commission = volumeSales * 7 / 100;
                }
                else if (volumeSales >= 1001 && volumeSales <= 10000)
                {
                    commission = volumeSales * 8 / 100;
                }
                else
                {
                    commission = volumeSales * 12 / 100;
                }
            }
            else if (town == "Varna")
            {
                if (0 <= volumeSales && volumeSales <= 500)
                {
                    commission = volumeSales * 4.5m / 100;
                }
                else if (volumeSales >= 501 && volumeSales <= 1000)
                {
                    commission = volumeSales * 7.5m / 100;
                }
                else if (volumeSales >= 1001 && volumeSales <= 10000)
                {
                    commission = volumeSales * 10 / 100;
                }
                else
                {
                    commission = volumeSales * 13 / 100;
                }
            }
            else if (town == "Plovdiv")
            {
                if (0 <= volumeSales && volumeSales <= 500)
                {
                    commission = volumeSales * 5.5m / 100;
                }
                else if (volumeSales >= 501 && volumeSales <= 1000)
                {
                    commission = volumeSales * 8 / 100;
                }
                else if (volumeSales >= 1001 && volumeSales <= 10000)
                {
                    commission = volumeSales * 12 / 100;
                }
                else
                {
                    commission = volumeSales * 14.5m / 100;
                }
            }
            if (commission > 0)
            {
                Console.WriteLine("{0:f2}",commission);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}


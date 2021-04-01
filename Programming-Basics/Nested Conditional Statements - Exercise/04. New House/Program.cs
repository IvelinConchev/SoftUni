using System;

namespace _04._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowersName = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double result = 0;

            switch (flowersName)
            {
                case "Roses":
                    result = numberOfFlowers * 5;

                    if (numberOfFlowers > 80)
                    {
                        result = result - result * 0.1;
                    }
                    break;
                case "Dahlias":
                    result = numberOfFlowers * 3.80;
                    if (numberOfFlowers > 90)
                    {
                        result = result - result * 0.15;
                    }
                    break;
                case "Tulips":
                    result = numberOfFlowers * 2.80;
                    if (numberOfFlowers > 80)
                    {
                        result = result - result * 0.15;
                    }
                    break;
                case "Narcissus":
                    result = numberOfFlowers * 3;
                    if (numberOfFlowers < 120)
                    {
                        result = result + result * 0.15;
                    }
                    break;
                case "Gladiolus":
                    result = numberOfFlowers * 2.50;
                    if (numberOfFlowers < 80)
                    {
                        result = result + result * 0.20;
                    }
                    break;

                default:
                    break;
            }
            double diff = Math.Abs(budget - result);

            if (budget >= result)
            {
                Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", numberOfFlowers, flowersName, diff);
            }
            else
            {
                Console.WriteLine("Not enough money, you need {0:f2} leva more.", diff);
            }
        }

    }
}


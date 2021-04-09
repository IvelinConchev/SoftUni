using System;

namespace Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            int batchNumber = int.Parse(Console.ReadLine());
            bool haveErrorsInBatch = false;
            bool isSugar = false;
            bool isEggs = false;
            bool isFlour = false;
            for (int currentBatch = 1; currentBatch <= batchNumber; currentBatch++)
            {
                if (!haveErrorsInBatch)
                {
                    isSugar = false;
                    isEggs = false;
                    isFlour = false;
                }
                string product = Console.ReadLine();
                while (product != "Bake!")
                {
                    switch (product)
                    {
                        case "sugar":
                            isSugar = true;
                            break;
                        case "eggs":
                            isEggs = true;
                            break;
                        case "flour":
                            isFlour = true;
                            break;
                    }
                    product = Console.ReadLine();
                }
                if (isFlour == true && isEggs == true && isSugar == true)
                {
                    haveErrorsInBatch = false;
                    Console.WriteLine("Baking batch number {0}...", currentBatch);
                }
                else
                {
                    currentBatch--;
                    haveErrorsInBatch = true;
                    Console.WriteLine("The batter should contain flour, eggs and sugar!");
                }
            }
        }
    }
}


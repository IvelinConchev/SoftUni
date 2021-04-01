using System;

namespace _03._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degree = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            if (degree >= 10 && degree <= 18)
            {
                if (timeOfDay == "Morning")
                {
                    string outfit = "Sweatshirt";
                    string shoes = "Sneakers";
                    Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                }
                else if (timeOfDay == "Afternoon")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                }
                else if (timeOfDay == "Evening")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                }
            }
            else if (degree > 18 && degree <= 24)
            {
                if (timeOfDay == "Morning")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                }
                else if (timeOfDay == "Afternoon")
                {
                    string outfit = "T-Shirt";
                    string shoes = "Sandals";
                    Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                }
                else if (timeOfDay == "Evening")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                }
            }
            else 
            {
                if (timeOfDay == "Morning")
                {
                    string outfit = "T-Shirt";
                    string shoes = "Sandals";
                    Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                }
                else if (timeOfDay == "Afternoon")
                {
                    string outfit = "Swim Suit";
                    string shoes = "Barefoot";
                    Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                }
                else if (timeOfDay == "Evening")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                }
            }
        }
    }
}

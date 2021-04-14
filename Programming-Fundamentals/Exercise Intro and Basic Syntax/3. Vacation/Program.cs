using System;

namespace _3._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string day = Console.ReadLine();

            decimal price = 1;

            switch (day)
            {
                case "Friday":
                    if (typeGroup == "Students")
                    {
                        price = 8.45m * people;
                        if (people >= 30)
                        {
                            price *= 0.85m;
                        }
                    }
                    else if (typeGroup == "Business")
                    {
                        if (people >= 100)
                        {
                            people -= 10;
                        }
                        price = 10.90m * people;
                    }
                    else if (typeGroup == "Regular")
                    {
                        price = 15 * people;
                        if (people > 10 && people <= 20)
                        {
                            price *= 0.95m;
                        }
                    }

                    break;
                case "Saturday":
                    if (typeGroup == "Students")
                    {
                        price = 9.80m * people;
                        if (people >= 30)
                        {
                            price *= 0.85m;
                        }
                    }
                    else if (typeGroup == "Business")
                    {
                        if (people >= 100)
                        {
                            people -= 10;
                        }
                        price = 15.60m * people;
                    }
                    else if (typeGroup == "Regular")
                    {
                        if (people > 10 && people <= 20)
                        {
                            price *= 0.95m;
                        }
                        price = 20 * people;
                    }
                    break;
                case "Sunday":
                    if (typeGroup == "Students")
                    {
                        price = 10.46m * people;
                        if (people >= 30)
                        {
                            price *= 0.85m;
                        }
                    }
                    else if (typeGroup == "Business")
                    {
                        if (people >= 100)
                        {
                            people -= 10;
                        }
                        price = 16 * people;
                    }
                    else if (typeGroup == "Regular")
                    {
                        price = 22.50m * people;
                        if (people > 10 && people <= 20)
                        {
                            price *= 0.95m;
                        }
                    }

                    //if (people >= 30)
                    //{
                    //    price *= 0.85m;
                    //}
                    //else if (people >= 100)
                    //{
                    //    price = price * people;
                    //}
                    //else if (people > 10 && people <= 20)
                    //{
                    //    price *= 0.95m;
                    //}
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}

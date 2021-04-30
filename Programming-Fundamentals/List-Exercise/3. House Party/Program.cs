using System;
using System.Collections.Generic;

namespace _3._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < number; i++)
            {
                string[] arrArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                //string guestName = arrArg[0];


                //string inGoing = arrArg[1];
                if (arrArg.Length > 3)
                {
                    if (guests.Contains(arrArg[0]))
                    {
                        guests.Remove(arrArg[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{arrArg[0]} is not in the list!");
                    }
                }
                else
                {
                    if (guests.Contains(arrArg[0]))
                    {
                        //guests.Remove(arrArg[0]);
                        Console.WriteLine($"{arrArg[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(arrArg[0]);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, guests));
        }
    }
}

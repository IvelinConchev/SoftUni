using System;
using System.Collections.Generic;

namespace _5._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> parking = new Dictionary<string, List<string>>();
 
            for (int i = 0; i < n; i++)
            {
                string[] arrArg = Console.ReadLine().Split();
                string command = arrArg[0];

                if (command == "register")
                {
                    string username = arrArg[1];
                    string licensePlateNumber = arrArg[2];

                    if (parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    else
                    {

                        parking.Add(username, new List<string> { username, licensePlateNumber });
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    string username = arrArg[1];
                    if (!parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        parking.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }
            foreach (var kvp in parking)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value[1]}");
            }
        }
    }
}

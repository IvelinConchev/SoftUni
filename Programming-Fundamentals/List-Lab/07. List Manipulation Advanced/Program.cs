using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string result = string.Empty;
            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "end")
            {

                switch (command[0])
                {
                    case "Contains":
                        // numbers.Contains(int.Parse(command[1]));
                        if (numbers.Contains(int.Parse(command[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            int currentNumber = numbers[i];
                            if (numbers[i] % 2 != 0)
                            {
                                Console.Write(currentNumber + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        //int sum = 0;
                        //for (int i = 0; i < numbers.Count; i++)
                        //{
                        //    sum += numbers[i];
                        //}
                        //Console.WriteLine(sum);
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        int index = int.Parse(command[2]);
                        if (command[1] == "<")
                        {
                            result = string.Join(" ", numbers
                                .Where(n => n < int.Parse(command[2])));
                        }
                        else if (command[1] == ">")
                        {
                            result = string.Join(" ", numbers
                                .Where(n => n > int.Parse(command[2])));
                        }
                        else if (command[1] == ">=")
                        {
                            result = string.Join(" ", numbers
                                .Where(n => n >= int.Parse(command[2])));
                        }
                        else if (command[1] == "<=")
                        {
                            result = string.Join(" ", numbers
                                .Where(n => n <= int.Parse(command[2])));
                        }
                        Console.WriteLine(result);
                        break;

                    default:
                        break;
                }
                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}

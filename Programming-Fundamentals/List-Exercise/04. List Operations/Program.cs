using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] arrArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (arrArgs[0] == "Add")
                {
                    numbers.Add(int.Parse(arrArgs[1]));
                }
                else if (arrArgs[0] == "Insert")
                {
                    int index = int.Parse(arrArgs[2]);
                    int element = int.Parse(arrArgs[1]);
                    if (index >= 0 && index <= numbers.Count)
                    {
                        numbers.Insert(index, element);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (arrArgs[0] == "Remove")
                {
                    int index = int.Parse(arrArgs[1]);
                    if (index >= 0 && index <= numbers.Count)
                    {
                        numbers.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (arrArgs[0] == "Shift")
                {
                    int rotation = int.Parse(arrArgs[2]);
                    if (arrArgs[1] == "left")
                    {
                        for (int i = 0; i < rotation; i++)
                        {
                            int firstElement = numbers[0];
                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                numbers[j] = numbers[j + 1]; 
                            }
                            numbers[numbers.Count - 1] = firstElement;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < rotation; i++)
                        {
                            int endElemnet = numbers[numbers.Count - 1];
                            for (int j = numbers.Count - 1; j > 0; j--)
                            {
                                numbers[j] = numbers[j - 1];
                            }
                            numbers[0] = endElemnet;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

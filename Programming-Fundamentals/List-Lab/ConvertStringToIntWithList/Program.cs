using System;
using System.Collections.Generic;
using System.Linq;

namespace ConvertStringToIntWithList
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();

            List<string> items = values.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<int> nums = new List<int>();
            for (int i = 0; i < items.Count; i++)
            {
                nums.Add(int.Parse(items[i]));
            }
            
                Console.WriteLine(string.Join(" ", nums));
            
        }
    }
}

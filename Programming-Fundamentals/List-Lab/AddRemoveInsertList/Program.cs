using System;
using System.Collections.Generic;

namespace AddRemoveInsertList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50, 60 };
            numbers.Remove(30);
            numbers.Add(100);
            numbers.Insert(0, -1);

            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine($"Count {numbers.Count}");
        }
    }
}

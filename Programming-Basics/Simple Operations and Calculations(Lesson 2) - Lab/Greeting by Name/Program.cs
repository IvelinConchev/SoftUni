using System;

namespace Greeting_by_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
            Console.WriteLine($"Hello, {name}!");
        }
    }
}

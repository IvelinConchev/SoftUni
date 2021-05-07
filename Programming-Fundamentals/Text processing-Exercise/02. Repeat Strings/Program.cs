using System;
using System.Linq;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = Console.ReadLine().Split();

            string result = string.Empty;
            foreach (var item in name)
            {
              result =  string.Concat(Enumerable.Repeat(item, item.Length));

            Console.Write(result);
            }

        }
    }
}

﻿using System;

namespace _9._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            char thirdSymbol = char.Parse(Console.ReadLine());

            Console.WriteLine($"{firstSymbol}{secondSymbol}{thirdSymbol}");
        }
    }
}

﻿using System;

namespace Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine("You are " + firstName + " " + lastName + "," + " "+"a"+ " "+ age +"-years old person from" + " "+ town + ".");
            //Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstName, lastName, age, town);
            //Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}. ");

        }
    }
}

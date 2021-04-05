using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameBook = Console.ReadLine();
            int numberOfLibrary = int.Parse(Console.ReadLine());
            int counter = 0;

            while (counter < numberOfLibrary)
            {
                string book = Console.ReadLine();

                if (book == nameBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                counter++;
            }
            if (counter == numberOfLibrary)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
            // Console.WriteLine(counter);
        }
    }
}

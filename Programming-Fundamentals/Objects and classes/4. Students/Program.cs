using System;
using System.Collections.Generic;

namespace _4._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arrArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = arrArgs[0];
                string lastName = arrArgs[1];
                int age = int.Parse(arrArgs[2]);
                string homeTown = arrArgs[3];

                Students student = new Students();

                student.firstName = firstName;
                student.lastName = lastName;
                student.age = age;
                student.homeTown = homeTown;

                students.Add(student);
            }
            string filterCity = Console.ReadLine();

            foreach (Students student in students)
            {
                if (student.homeTown == filterCity)
                {
                    Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
                }
            }
        }
    }
    class Students
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string homeTown { get; set; }
    }
}

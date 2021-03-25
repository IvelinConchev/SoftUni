using System;

namespace _05._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int project = number * 3;
            Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s.", name, project, number);
        }
    }
}

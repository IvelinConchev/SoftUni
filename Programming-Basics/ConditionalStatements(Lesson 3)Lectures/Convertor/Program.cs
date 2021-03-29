using System;

namespace Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());// 1
            string inputUnit = Console.ReadLine();// sm
            string outputUnit = Console.ReadLine();// m

            if (inputUnit == "cm")
            {
                distance = distance * 10;
            }
            else if (inputUnit == "m")
            {
                distance = distance * 1000;
            }
            // distance is in "mm"
            if (outputUnit == "cm")
            {
                distance = distance / 10;
            }
            else if (outputUnit == "m")
            {
                distance = distance / 1000;
            }
            // distance is in desired output unit 
            Console.WriteLine("{0:f3}", distance);
        }
    }
}

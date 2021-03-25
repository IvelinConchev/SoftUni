using System;

namespace _08._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double meter = double.Parse(Console.ReadLine());
            double area = meter * 7.61;
            double discount = 0.18 * area;
            double result = area - discount;
            Console.WriteLine("The final price is: {0:F2} lv.", result);
            Console.WriteLine("The discount is: {0:F2} lv.", discount);
            int n = int.Parse(Console.ReadLine());
        }
    }
}

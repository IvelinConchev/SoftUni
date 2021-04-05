using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int cakeSize = width * length;
            bool finished = true;

            
            while (true)
            {
                string current = Console.ReadLine();
                if (current == "STOP")
                {
                    break;
                }
                cakeSize = cakeSize - int.Parse(current);
                if (cakeSize < 0)
                {
                    finished = false;
                    break;
                }
            }
            if (finished == false)
            {
                Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(cakeSize));
            }
            else
            {
                Console.WriteLine("{0} pieces are left.", cakeSize);
            }
        }
    }
}

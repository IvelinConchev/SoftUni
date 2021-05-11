using System;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;

            while ((text = Console.ReadLine()) != "Generate")
            {
                string[] arrArg = text.Split(">>>",StringSplitOptions.RemoveEmptyEntries);
                string command = arrArg[0];
                int startIndex = int.Parse(arrArg[1]);
                int endIndex = int.Parse(arrArg[2]);

                if (command == "Slice")
                {
                   text =  text.Substring(startIndex, endIndex);
                    Console.WriteLine(text);
                }
            }
        }
    }
}

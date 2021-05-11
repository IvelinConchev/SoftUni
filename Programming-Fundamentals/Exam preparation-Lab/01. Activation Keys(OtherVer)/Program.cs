using System;
using System.Text;

namespace _01._Activation_Keys_OtherVer_
{
    class Program
    {
        static void Main(string[] args)
        {
            string activateKey = Console.ReadLine();

            string input;

            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] arrArg = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string command = arrArg[0];

                if (command.Contains("Contains"))
                {
                    string substring = arrArg[1];
                    if (activateKey.Contains(substring))
                    {
                        Console.WriteLine($"{activateKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command.Contains("Flip"))
                {
                    string upper = arrArg[1];
                    int startIndex = int.Parse(arrArg[2]);
                    int endIndex = int.Parse(arrArg[3]);
                    if (upper.Contains("Upper"))
                    {
                        StringBuilder sb = new StringBuilder();
                        string firstPart = activateKey.Substring(0, startIndex);
                        string secondPart = activateKey.Substring(startIndex, endIndex - startIndex).ToUpper();
                        string thirdPart = activateKey.Substring(endIndex);
                        sb.Append(firstPart);
                        sb.Append(secondPart);
                        sb.Append(thirdPart);
                        activateKey = sb.ToString();
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder();
                        string firstPart = activateKey.Substring(0, startIndex);
                        string secondPart = activateKey.Substring(startIndex, endIndex - startIndex).ToLower();
                        string thirdPart = activateKey.Substring(endIndex);
                        sb.Append(firstPart);
                        sb.Append(secondPart);
                        sb.Append(thirdPart);


                        activateKey = sb.ToString();
                    }
                    Console.WriteLine(activateKey);
                }
                else if (command.Contains("Slice"))
                {
                    int startIndex = int.Parse(arrArg[1]);
                    int endIndex = int.Parse(arrArg[2]);

                    activateKey = activateKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activateKey);
                }
            }

            Console.WriteLine($"Your activation key is: {activateKey}");
        }
    }
}

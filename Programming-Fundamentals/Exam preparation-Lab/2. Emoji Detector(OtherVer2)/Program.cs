using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2._Emoji_Detector_OtherVer2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string digitPattern = @"\d";
            string emojiPattern = @"(:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";
            List<string> emoji = new List<string>();
            int resultLetter = 0;
            string input = Console.ReadLine();
            int result = 1;
            

            Match digMatch = Regex.Match(input, digitPattern);
            Match letterMatch = Regex.Match(input, emojiPattern);

            if ((digMatch.Success) || (letterMatch.Success))
            {
                int multiply = 1;
                string digit = digMatch.Value;
                for (int l = 0; l < input.Length; l++)
                {
                    if (char.IsDigit(input[l]))
                    {
                        multiply *= int.Parse(input[l].ToString());
                    }
                }
                //Console.WriteLine(multiply);

                for (int i = 0; i < input.Length; i++)
                {
                    string letter = letterMatch.Groups["emoji"].Value;
                     resultLetter = 0;
                    for (int j = 0; j < letter.Length; j++)
                    {
                        if (char.IsLetter(letter[j]))
                        {
                            resultLetter += (int)letter[j];
                           
                        }
                    }
                    if (multiply < resultLetter)
                    {
                        emoji.Add(letterMatch.Value);
                    }
                }
                Console.WriteLine($"Cool threshold: {multiply}");
                Console.WriteLine($"{count} emojis found in the text. The cool ones are:");
                foreach (var emojii in emoji)
                {
                    Console.WriteLine(emoji);
                }
            }
        }
    }
}


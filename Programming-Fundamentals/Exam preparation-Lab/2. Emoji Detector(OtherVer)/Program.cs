using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Emoji_Detector_OtherVer_
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberPattern = @"\d";
            string emojiPattern = @"([:]{2}|[*]{2})(?<name>[A-Z][a-z]{2,})\1";

            Regex numReg = new Regex(numberPattern);
            Regex emojiReg = new Regex(emojiPattern);

            List<string> coolEmoji = new List<string>();
            int coolTreshold = 0;
            int emojisInText = 0;
            int sumEmoji = 0;

            string text = Console.ReadLine();

            if (numReg.IsMatch(text) || emojiReg.IsMatch(text))
            {
                MatchCollection matchesNum = numReg.Matches(text);
                var matchesToArr = matchesNum.Select(v => int.Parse(v.Value)).ToArray();
                coolTreshold = matchesToArr.Aggregate(1, (a, b) => a * b);
                MatchCollection emojis = emojiReg.Matches(text);
                emojisInText += emojis.Count;

                foreach (Match emoji in emojis)
                {
                    string emojiToString = emoji.Groups["name"].Value;

                    for (int curr = 0; curr < emojiToString.Length; curr++)
                    {
                        if (char.IsLetter(emojiToString[curr]))
                        {
                            sumEmoji += emojiToString[curr];
                        }
                    }
                    if (sumEmoji > coolTreshold)
                    {
                        coolEmoji.Add(emoji.Value);
                    }
                }
                Console.WriteLine($"Cool threshold: {coolTreshold}");
                Console.WriteLine($"{emojisInText} emojis found in the text. The cool ones are:");
                foreach (var emoji in coolEmoji)
                {
                    Console.WriteLine(emoji);
                }
            }
        }
    }
}

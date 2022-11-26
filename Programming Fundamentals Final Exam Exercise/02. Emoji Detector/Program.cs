using System;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberPattern = @"(?<number>[0-9])";
            string emojiPattern = @"(:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";
            Regex numberRegex = new Regex(numberPattern);
            Regex emojiRegex = new Regex(emojiPattern);
            BigInteger coolThreshold = 1;
            

            string input = Console.ReadLine();
            MatchCollection matches = emojiRegex.Matches(input);
            MatchCollection numberMatches = numberRegex.Matches(input);

            foreach (Match number in numberMatches)
            {
                coolThreshold *= int.Parse(number.ToString());
            }
            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            foreach (Match item in matches)
            {                
                string emoji = item.Groups["emoji"].ToString();
                int coolness = 0;

                for (int i = 0; i < emoji.Length; i++)
                {
                    coolness += emoji[i];
                }
                
                if (coolness >= coolThreshold)
                {
                    Console.WriteLine(item.Value);
                }
                
            }
        }
    }
}

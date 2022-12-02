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
            string pattern = @"(:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            BigInteger coolThreshold = CalculateCoolnessThreshold(input);

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

        static BigInteger CalculateCoolnessThreshold(string input)
        {
            BigInteger coolnessThreshold = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    coolnessThreshold *= int.Parse(input[i].ToString());
                }
            }
            return coolnessThreshold;
        }
    }
}


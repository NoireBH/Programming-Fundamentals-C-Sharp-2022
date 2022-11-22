using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"(@|#)(?<wordOne>[A-Za-z]{3,})\1\1(?<wordTwo>[A-Z-a-z]{3,})\1";
            MatchCollection matches = Regex.Matches(input, regex);
            var results = new Dictionary<string, string>();

            foreach (Match match in matches)
            {

                string firstWord = match.Groups["wordOne"].Value;
                string secondWord = match.Groups["wordTwo"].Value;
                string secondWordReversed = string.Join("", secondWord.ToCharArray().Reverse());
                if (firstWord == secondWordReversed)
                    results.Add(firstWord, secondWord);
            }

            if (matches.Count == 0)
                Console.WriteLine("No word pairs found!");
            else
                Console.WriteLine($"{matches.Count} word pairs found!");

            if (results.Count == 0)
                Console.WriteLine("No mirror words!");
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(String.Join(", ", results.Select(x => $"{x.Key} <=> {x.Value}")));
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> racers = new Dictionary<string, int>();
            string namePattern = @"(?<name>[A-Za-z]+)";
            string numberPattern = @"(?<numbers>\d+)";
            Regex regexForNames = new Regex(namePattern);
            Regex regexForNumbers = new Regex(numberPattern);
            var participants = Console.ReadLine()
                .Split(", ")
                .ToList();
            string input;
            
            while ((input = Console.ReadLine()) != "end of race")
            {   
                string currParticipant = input;
                MatchCollection nameMatches = regexForNames.Matches(currParticipant);
                MatchCollection numberMatches = regexForNumbers.Matches(currParticipant);
                string names = string.Join("", nameMatches);
                string numbers = string.Join("", numberMatches);
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += int.Parse(numbers[i].ToString());

                }

                if (participants.Contains(names))
                {
                    if (!racers.ContainsKey(names))
                    {
                        racers.Add(names, sum);
                    }

                    else
                    {
                        racers[names] += sum;
                    }
                }
                
            }

            racers = racers.OrderByDescending(X => X.Value).ToDictionary(X => X.Key, X => X.Value);
            Console.WriteLine($"1st place: {racers.Keys.ElementAt(0)}");
            Console.WriteLine($"2nd place: {racers.Keys.ElementAt(1)}");
            Console.WriteLine($"3rd place: {racers.Keys.ElementAt(2)}");



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            string pattern = @"[s,t,a,r,S,T,A,R]";
            string patternAfterDecryption = @"@(?<planetName>[A-za-z]+)[^\@\-\!\:>]*?:(?<population>\d+)[^\@\-\!\:>]*?!(?<attackType>A|D)![^\@\-\!\:>]*?->(?<soldiers>\d+)";
            int n = int.Parse(Console.ReadLine());
            Regex regex = new Regex(pattern);
            Regex regex2 = new Regex(patternAfterDecryption);
            

            for (int i = 0; i < n; i++)
            {
                StringBuilder decryptedMessage = new StringBuilder();
                int countMatched = 0;
                string encryptedMessage = Console.ReadLine();
                MatchCollection matchCollection = regex.Matches(encryptedMessage);
                foreach (Match item in matchCollection)
                {
                    countMatched++;
                }

                foreach (char oldChar in encryptedMessage)
                {
                    decryptedMessage.Append((char)(oldChar - countMatched));
                }

                
                MatchCollection matchCollection2 = regex2.Matches(decryptedMessage.ToString());

                foreach (Match match in matchCollection2)
                {
                    string planetName = match.Groups["planetName"].Value;
                    string attackType = match.Groups["attackType"].Value;

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (attackType == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            
            
                Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

                foreach (var attPlanet in attackedPlanets.OrderBy(p => p))
                {
                    Console.WriteLine($"-> {attPlanet}");
                }
            

           
                Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

                foreach (var destPlanet in destroyedPlanets.OrderBy(p => p))
                {
                    Console.WriteLine($"-> {destPlanet}");
                }
            
            

        }
    }
}

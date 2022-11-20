using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namesCollection = Console.ReadLine()
            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Regex regexForHealth = new Regex(@"[^\d\+\-*\/\.]");
            Regex regexForDamage = new Regex(@"(?:\+|-)?[0-9]+(?:\.[0-9]+)?");
            Regex regexForMultiplyOrDivideSymbols = new Regex(@"[*\/]");
            var dictNamesHealth = new Dictionary<string, int>();
            var dictNamesDamage = new Dictionary<string, double>();

            foreach (string name in namesCollection)
            {
                MatchCollection matchesForHealth = regexForHealth.Matches(name);
                if (regexForHealth.IsMatch(name))
                {
                    int health = 0;
                    foreach (Match match in matchesForHealth)
                    {
                        char symbol = char.Parse(match.ToString());
                        int symbolInt = symbol;
                        health += symbolInt;
                    }

                    dictNamesHealth.Add(name, health);
                }

                double damage = 0;
                MatchCollection matchesForDamage = regexForDamage.Matches(name);
                if (regexForDamage.IsMatch(name))
                {
                    foreach (Match match in matchesForDamage)
                    {
                        damage += double.Parse(match.ToString());
                    }
                }

                MatchCollection matchesForMultiplyOrDivideSymbols = regexForMultiplyOrDivideSymbols.Matches(name);
                if (regexForMultiplyOrDivideSymbols.IsMatch(name))
                {
                    foreach (Match match in matchesForMultiplyOrDivideSymbols)
                    {
                        if (match.ToString() == "*")
                        {
                            damage = damage * 2;
                        }

                        else if (match.ToString() == "/")
                        {
                            damage = damage / 2;
                        }
                    }
                }

                dictNamesDamage.Add(name, damage);
            }

            foreach (var kvp in dictNamesHealth.OrderBy(x => x.Key))
            {
                string name = kvp.Key;
                int health = kvp.Value;
                double damage = dictNamesDamage[name];
                Console.WriteLine($"{name} - {health} health, {damage:F2} damage");
            }
        }
    }
}

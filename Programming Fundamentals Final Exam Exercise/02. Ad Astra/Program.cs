using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(\||#)(?<name>[A-za-z\s]+)\1(?<expiration>(?<day>\d{2})\/(?<month>\d{2})\/(?<year>\d{2}))\1(?<calories>\d+)\1";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            int totalCalories = 0;
            int count = 0;
            foreach (Match item in matches)
            {

                int calories = int.Parse(item.Groups["calories"].Value);
                totalCalories += calories;


            }

            while (totalCalories >= 2000)
            {
                totalCalories -= 2000;
                count++;
            }

            Console.WriteLine($"You have food to last you for: {count} days!");

            foreach (Match item in matches)
            {
                string name = item.Groups["name"].Value;
                string expiration = item.Groups["expiration"].Value;
                int calories = int.Parse(item.Groups["calories"].Value);
                Console.WriteLine($"Item: {name}, Best before: {expiration}, Nutrition: {calories}");
            }
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int totalCalories = 0;
            int caloriesDIvided = 0;
            int count = 0;
            string pattern = @"(#|\|)(?<name>[A-za-z\s]+)\1(?<expiration>(?<day>\d{2})\/(?<month>\d{2})\/(?<year>\d{2}))\1(?<calories>\d+)\1";
            string text = Console.ReadLine();
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);
                
            foreach (Match match in matches)
            {
                int calories = int.Parse(match.Groups["calories"].Value);

                totalCalories += calories;
            }
                

                
                
            

            caloriesDIvided = totalCalories;

            while (caloriesDIvided >= 2000)
            {
                caloriesDIvided -= 2000;
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

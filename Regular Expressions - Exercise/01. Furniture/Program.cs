using System;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double totalMoneySpent = 0;
            Console.WriteLine("Bought furniture:");

            while ((input = Console.ReadLine())!="Purchase")
            {
                
                string namePattern = @">>(?<furniture>[A-zaz]+)+<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";
                Regex regex = new Regex(namePattern);
                
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string furniture = match.Groups["furniture"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    
                    Console.WriteLine(furniture);
                     totalMoneySpent += price * quantity;

                }
               

            }
            Console.WriteLine($"Total money spend: {totalMoneySpent:f2}");
        }
    }
}

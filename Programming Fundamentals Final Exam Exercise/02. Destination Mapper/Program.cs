using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthOfTravel = 0;
            string pattern = @"(=|\/)(?<location>[A-Z][A-Za-z]{2,})\1";
            string locations = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection places = regex.Matches(locations);
           
            foreach (Match place in places)
            {
                string matchedLocation = place.Groups["location"].Value;
                lengthOfTravel += matchedLocation.Length;
                
            }
            
            Console.WriteLine($"Destinations: {string.Join(", ", places.Select(x => x.Groups["location"].Value))}");
            Console.WriteLine($"Travel Points: {lengthOfTravel}");


        }
    }
}

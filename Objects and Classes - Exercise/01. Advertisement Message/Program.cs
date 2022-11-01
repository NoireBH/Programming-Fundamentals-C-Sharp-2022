using System;
using System.Collections.Generic;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string>()
            {
              "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product."
            };
            List<string> events = new List<string>()
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };
            List<string> authors = new List<string>()
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };
            List<string> cities = new List<string>()
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };


            int messageNum = int.Parse(Console.ReadLine());


            Random phrase = new Random();
            Random event1 = new Random();
            Random author = new Random();
            Random city = new Random();

            for (int i = 0; i < messageNum; i++)
            {
                int phraseIndex = phrase.Next(0,phrases.Count);
                int event1Index = event1.Next(0,phrases.Count);
                int authorIndex = author.Next(0,phrases.Count);
                int cityIndex = city.Next(0,phrases.Count);
                Console.WriteLine($"{phrases[phraseIndex]} {events[event1Index]} {authors[authorIndex]} - {cities[cityIndex]}.");
            }

             }
    }
}

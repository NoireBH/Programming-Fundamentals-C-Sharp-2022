using System;

namespace _6._Foreign_Languages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfCountry = Console.ReadLine();

            switch (nameOfCountry)
            {
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "England":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}

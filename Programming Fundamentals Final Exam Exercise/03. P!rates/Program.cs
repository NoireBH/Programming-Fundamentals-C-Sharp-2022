using System;
using System.Collections.Generic;

namespace _03._P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new Dictionary<string, City>();
            string input;

            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] parts = input.Split("||");
                string cityName = parts[0];
                int population = int.Parse(parts[1]);
                double gold = double.Parse(parts[2]);

                City city = new City(population, gold);
                if (!cities.ContainsKey(cityName))
                {
                    cities.Add(cityName, city);
                }

                else
                {
                    cities[cityName].population += population;
                    cities[cityName].gold += gold;
                }

            }

            string input2;
            while ((input2 = Console.ReadLine()) != "End")
            {
                string[] cmd = input2.Split("=>");
                string command = cmd[0];
                string town = cmd[1];
                
                if (command == "Plunder")
                {
                    int people = int.Parse(cmd[2]);
                    double gold = double.Parse(cmd[3]);
                    if (cities.ContainsKey(town))
                    {
                        cities[town].population -= people;
                        cities[town].gold -= gold;
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                        if (cities[town].population <= 0 | cities[town].gold <= 0)
                        {
                            Console.WriteLine($"{town} has been wiped off the map!");
                            cities.Remove(town);
                        }
                    }
                }

                else if (command == "Prosper")
                {
                    double goldAdded = double.Parse(cmd[2]);
                    if (goldAdded < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }

                    if (cities.ContainsKey(town))
                    {
                        cities[town].gold += goldAdded;
                        Console.WriteLine($"{goldAdded} gold added to the city treasury. {town} now has {cities[town].gold} gold.");
                    }
                }

            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.population} citizens, Gold: {city.Value.gold} kg");
                }

            }

            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

        }

        class City
        {
            public City(int population, double gold)
            {
                this.population = population;
                this.gold = gold;
            }

            public int population { get; set; }
            public double gold { get; set; }
        }
    }
}

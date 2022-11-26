using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> plantsRarity = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantRating = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] infoPlants = Console.ReadLine().Split("<->");
                string plant = infoPlants[0];
                int rarity = int.Parse(infoPlants[1]);
                if (!plantsRarity.ContainsKey(plant))
                {
                    plantsRarity.Add(plant, rarity);
                    plantRating.Add(plant, new List<double>());
                }
                else
                {
                    plantsRarity[plant] = rarity;
                }
            }

            string input;

            while ((input = Console.ReadLine())!= "Exhibition")
            {
                string[] cmd = input.Split(":" , StringSplitOptions.RemoveEmptyEntries);
                string command = cmd[0];
                string[] cmdArg = cmd[1].Trim().Split("-" , StringSplitOptions.RemoveEmptyEntries);
                string plant = cmdArg[0].Trim();

                if (command == "Rate")
                {    
                    double rating = double.Parse(cmdArg[1]);

                    if (plantsRarity.ContainsKey(plant))
                    {
    
                        plantRating[plant].Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }

                else if (command == "Update")
                {
                    if (plantsRarity.ContainsKey(plant))
                    {
                        int rarity = int.Parse(cmdArg[1]);
                        plantsRarity[plant] = rarity;

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    
                }

                else if (command == "Reset")
                {
                    if (plantsRarity.ContainsKey(plant))
                    {
                        plantRating[plant].Clear();
                        

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }
            Console.WriteLine("Plants for the exhibition:");
            
            foreach (var plant in plantsRarity)
            {
                if (plantRating[plant.Key].Count > 0)
                {
                    double currRating = plantRating[plant.Key].Average();
                    Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value}; Rating: {currRating:f2}");
                }
                else
                {
                    Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value}; Rating: {0:f2}");
                }                                   
                
            }           
        }
    }
}

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
                        if (!plantRating.ContainsKey(plant))
                        {
                            plantRating.Add(plant, new List<double>());
                        }
                        
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
                double currentRating = 0;
                List<double> listRating = new List<double>();

                foreach (var rating in plantRating)
                {
                    if (plant.Key == rating.Key)
                    {
                        listRating = rating.Value;
                        break;
                    }
                }

                if (listRating.Count > 0)
                {
                    currentRating = listRating.Average();

                }
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value}; Rating: {currentRating:f2}");
            }
            


        }
    }
}

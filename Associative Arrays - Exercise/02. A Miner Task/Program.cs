using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourcesQuantity = new Dictionary<string, int>();
            string input;
           
            while ((input = Console.ReadLine())!= "stop")
            {
                string resource = input;
                int quantity = int.Parse(Console.ReadLine());

                
                
                    if (!resourcesQuantity.ContainsKey(resource))
                    {
                        resourcesQuantity.Add(resource, quantity);
                    }
                else
                {
                    resourcesQuantity[resource] += quantity;
                }
                    
                
                
            }
            foreach (var item in resourcesQuantity)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

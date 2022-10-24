using System;

namespace _01._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal energy = decimal.Parse(Console.ReadLine());

            string command;
            
            int wonBattles = 0;
            while ((command = Console.ReadLine())!= "End of battle")
            {   
                decimal distanceNeeded = decimal.Parse(command);
                if (energy < distanceNeeded)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                    return;
                    
                }
                else
                {
                    energy -= distanceNeeded;
                    wonBattles++;
                    if (wonBattles % 3 == 0)
                    {
                        energy += wonBattles;
                    }
                }

            }
            if (energy >= 0)
            {
                Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
            }
           
            
        }
    }
}

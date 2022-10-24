using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoin = 0;
            

            List<string> dungeonRooms = Console.ReadLine()
                .Split('|')
                .ToList();
            for (int i = 0; i < dungeonRooms.Count; i++)
            {
                string[] command = dungeonRooms[i].Split();
                if (health <= 0)
                {
                    break;
                }
                if (command[0] == "potion")
                {
                    int beforeHeal = health;
                    int heal = int.Parse(command[1]);
                    health += heal;
                    if (health > 100)
                    {
                        heal = 100 - beforeHeal;
                    }
                    
                    Console.WriteLine($"You healed for {heal} hp.");
                    if (health > 100)
                    {
                        health = 100;
                    }
                    Console.WriteLine($"Current health: {health} hp.");

                }
                else if (command[0] == "chest")
                {
                    int foundBitcoins = int.Parse(command[1]);
                    bitcoin += foundBitcoins;
                    Console.WriteLine($"You found {foundBitcoins} bitcoins.");
                }
                else
                {
                    string monster = command[0];
                    int attack = int.Parse(command[1]);
                    health -= attack;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {i + 1}");
                    }
                }
            }
            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoin}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}

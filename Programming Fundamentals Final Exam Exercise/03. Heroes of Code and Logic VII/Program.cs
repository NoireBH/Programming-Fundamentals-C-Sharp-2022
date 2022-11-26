using System;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var heroes = new Dictionary<string, HeroStats>();
            int numberOfHeroes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] infoOnHeroes = Console.ReadLine().Split(' ');
                string heroName = infoOnHeroes[0];
                int heroHp = int.Parse(infoOnHeroes[1]);
                int heroMp = int.Parse(infoOnHeroes[2]);
                HeroStats herostats = new HeroStats(heroHp, heroMp);

                if (!heroes.ContainsKey(heroName))
                {
                    heroes.Add(heroName, herostats);
                }
                

            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmd = input.Split(" - ");
                string command = cmd[0];
                string heroName = cmd[1];

                if (command == "CastSpell")
                {
                    int mpNeeded = int.Parse(cmd[2]);
                    
                    if (heroes[heroName].MP >= mpNeeded)
                    {
                        string spell = cmd[3];
                        heroes[heroName].MP -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spell} and now has {heroes[heroName].MP} MP!");
                    }
                    else
                    {
                        string spell = cmd[3];
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spell}!");
                    }
                    
                }

                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(cmd[2]);
                    string attacker = cmd[3];
                    heroes[heroName].HP -= damage;
                    if (heroes[heroName].HP > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].HP} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroes.Remove(heroName);
                    }
                }

                else if (command == "Recharge")
                {
                    int amount = int.Parse(cmd[2]);
                    int oldMP = heroes[heroName].MP;
                    heroes[heroName].MP += amount;
                    
                    if (heroes[heroName].MP > 200)
                    {
                        Console.WriteLine($"{heroName} recharged for {200 - oldMP} MP!");
                        heroes[heroName].MP = 200;
                        

                    }
                    else
                    {
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                }

                else if (command == "Heal")
                {
                    int amount = int.Parse(cmd[2]);
                    int oldHP = heroes[heroName].HP;
                    heroes[heroName].HP += amount;
                    
                    if (heroes[heroName].HP > 100)
                    {
                        Console.WriteLine($"{heroName} healed for {100 - oldHP} HP!");
                        heroes[heroName].HP = 100;
                        

                    }
                    else
                    {
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }
                }
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($" HP: {hero.Value.HP}");
                Console.WriteLine($" MP: {hero.Value.MP}");
            }
        }

        class HeroStats
        {    public HeroStats(int hp, int mp)
            {
                HP = hp;
                MP = mp;
            }
            public int HP { get; set; }
            public int MP { get; set; }

        }
    }
}

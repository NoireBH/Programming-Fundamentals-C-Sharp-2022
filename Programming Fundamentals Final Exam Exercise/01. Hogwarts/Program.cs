using System;
using System.Text;

namespace _01._Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder spell = new StringBuilder(Console.ReadLine());

            string input;

            while ((input = Console.ReadLine()) != "Abracadabra")
            {
                string[] cmd = input.Split(" ");
                string command = cmd[0];

                if (command == "Abjuration")
                {
                    string upperSpell = spell.ToString().ToUpper();
                    spell.Clear();
                    spell.Append(upperSpell);
                    Console.WriteLine(spell);
                }

                else if (command == "Necromancy")
                {
                    string lowerSpell = spell.ToString().ToLower();
                    spell.Clear();
                    spell.Append(lowerSpell);
                    Console.WriteLine(spell);
                }

                else if (command == "Illusion")
                {
                    int index = int.Parse(cmd[1]);
                    char letter = char.Parse(cmd[2]);

                    if (index >= 0 && index < spell.Length)
                    {
                        spell.Remove(index, 1);
                        spell.Insert(index, letter);
                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                }

                else if (command == "Divination")
                {
                    string firstSubstring = cmd[1];
                    string secondSubstring = cmd[2];

                    if ((spell.ToString().Contains(firstSubstring)))
                    {
                        spell.Replace(firstSubstring, secondSubstring);
                        Console.WriteLine(spell);
                    }
    
                }

                else if (command == "Alteration")
                {
                    string substring = cmd[1];

                    if (spell.ToString().Contains(substring))
                    {
                        int startIndex = spell.ToString().IndexOf(substring);
                        
                        spell.Remove(startIndex, substring.Length);
                        Console.WriteLine(spell);
                    }
                }

                else
                {
                    Console.WriteLine("The spell did not work!");
                }
            }

            
        }
    }
}

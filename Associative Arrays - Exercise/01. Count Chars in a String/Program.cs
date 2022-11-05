using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> characters = new Dictionary<char, int>();
            string word = Console.ReadLine()
                .Trim();
            char[] chars = word
                .ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (!characters.ContainsKey(chars[i]))
                {
                    characters.Add(chars[i], 0);
                }
                characters[chars[i]]++;
            }
            foreach (var character in characters)
            {
                if (character.Key != ' ')
                {
                    Console.WriteLine($"{character.Key} -> {character.Value}");
                }
                
            }

            

        }
    }
}

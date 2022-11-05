using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> wordsWithSynonyms = new Dictionary<string, List<string>>();
            
            int countOfWords = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfWords; i++)
            {
                string word = Console.ReadLine();
                string synonym  = Console.ReadLine();
                
                if (!wordsWithSynonyms.ContainsKey(word))
                {
                    wordsWithSynonyms.Add(word, new List<string>());
                    
                }
                wordsWithSynonyms[word].Add(synonym);

            }
            foreach (var item in wordsWithSynonyms)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> count = new Dictionary<string, int>();
            string[] words = Console.ReadLine()
                .Split();




            foreach (var word in words)
            {
                string wordsLowerCase = word.ToLower();
                if (!count.ContainsKey(wordsLowerCase))
                {
                    count.Add(wordsLowerCase, 0);
                }
                count[wordsLowerCase]++;
            }
            foreach (var word in count)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write(word.Key + " ");
                }
            }
        }


    }
}

using System;
using System.Linq;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ');
                
            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {   string currentWord = words[i];
                int randomIndex = random.Next(0, words.Length);
                string nextWord = words[randomIndex];
                words[i] = nextWord;
                words[randomIndex] = currentWord;
                
            }
            Console.WriteLine(String.Join(Environment.NewLine, words));
        }
    }
}

using System;

namespace _2._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a method that receives a single string and prints out the number of vowels contained in it.
            string sentence = Console.ReadLine().
                ToLower();
              
            int totalVowels = GetNumberOfVowels(sentence);
            Console.WriteLine(totalVowels);    
        }
        static int GetNumberOfVowels(string sentence)
        {
            int totalVowels = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u')
                {
                    totalVowels++;
                }
            }
            return totalVowels;
        }

    }
}

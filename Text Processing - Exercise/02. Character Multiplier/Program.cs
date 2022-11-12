using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string firstWord = words[0];
            string secondWord = words[1];
            

            int result = GetSum(firstWord, secondWord);
            Console.WriteLine(result);

        }

      public static int GetSum(string firstWord ,string secondWord)
        {
            int minLenght = Math.Min(firstWord.Length, secondWord.Length);
            int maxLenght = Math.Max(firstWord.Length, secondWord.Length);
            string longerString = string.Empty;
            if (firstWord.Length > secondWord.Length)
            {
                 longerString = firstWord;
            }
            else
            {
                 longerString = secondWord;
            }
            int sum = 0;

            for (int i = 0; i < minLenght; i++)
            {   
                   sum += firstWord[i] * secondWord[i];
            }

            for (int i = minLenght; i < maxLenght; i++)
            {
                
                sum += longerString[i];
            }
            return sum;
            
        }
    }
}

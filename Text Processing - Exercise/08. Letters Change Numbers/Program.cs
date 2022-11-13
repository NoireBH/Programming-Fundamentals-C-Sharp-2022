using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numberBetweenTwoLetters = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;

            foreach (var word in numberBetweenTwoLetters)
            {
                
                char firstLetter = word[0];
                char lastLetter = word[word.Length - 1];
                double number = double.Parse(word[1..^1]);

                if (char.IsUpper(firstLetter))
                {
                    int positionOfLetter = firstLetter - 64;
                    number /= positionOfLetter;
                }
                else
                {
                    int positionOfLetter = firstLetter - 96;
                    number *= positionOfLetter;
                }

                if (char.IsUpper(lastLetter))
                {
                    int positionOfLetter = lastLetter - 64;
                    number -= positionOfLetter;
                }
                else
                {
                    int positionOfLetter = lastLetter - 96;
                    number += positionOfLetter;
                }
                sum += number;      
            }
            Console.WriteLine($"{sum:f2}");


        }


    }
}

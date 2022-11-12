using System;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sequenceOfLetters = Console.ReadLine();

            char previousLetter = sequenceOfLetters[0];
            Console.Write(previousLetter);

            for (int i = 1; i < sequenceOfLetters.Length; i++)
            {
                if (previousLetter != sequenceOfLetters[i])
                {
                    previousLetter = sequenceOfLetters[i];
                    Console.Write(previousLetter);
                }
            }
        }
    }
}

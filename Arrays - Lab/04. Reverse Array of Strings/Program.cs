using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] letters = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < letters.Length / 2; i++)
            {
                string currentLetter = letters[i];
                letters[i] = letters[letters.Length - 1 - i];
                letters[letters.Length - i - 1] = currentLetter;

            }
            Console.WriteLine(String.Join(" ", letters));



        }
    }
}

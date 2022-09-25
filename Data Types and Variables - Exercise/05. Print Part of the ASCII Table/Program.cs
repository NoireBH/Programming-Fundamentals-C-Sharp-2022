using System;

namespace _05._Print_Part_of_the_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingLetter = int.Parse(Console.ReadLine());
            int endingLetter = int.Parse(Console.ReadLine());

            for (int i = startingLetter; i <= endingLetter; i++)
            {
                char currentLetter = (char)i;
                Console.Write($"{currentLetter} ");
            }
        }
    }
}

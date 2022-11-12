using System;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char [] chars = input.ToCharArray();

            foreach (var number in chars)
            {
                if (Char.IsDigit(number))
                {
                    Console.Write(number);
                }
            }

            Console.WriteLine();

            foreach (var letter in chars)
            {
                if (Char.IsLetter(letter))
                {
                    Console.Write(letter);
                }
            }

            Console.WriteLine();

            foreach (var symbol in chars)
            {
                if (!Char.IsLetterOrDigit(symbol))
                {
                    Console.Write(symbol);
                }
            }
        }
    }
}

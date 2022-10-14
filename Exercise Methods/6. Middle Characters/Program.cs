using System;

namespace _6._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string middleChar = GetMiddleCharacter(input);
            Console.WriteLine(middleChar);

        }
        static string GetMiddleCharacter(string input)
        {
            int length = input.Length;
            string middleChar = string.Empty;

            if (length % 2 == 1)
            {
                middleChar = input[input.Length / 2].ToString();
            }
            else
            {
                middleChar = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
            }

            return middleChar;
        }
    }
}

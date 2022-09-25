using System;

namespace _4._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                char current = word[i];
                Console.Write(current);
            }
        }
    }
}

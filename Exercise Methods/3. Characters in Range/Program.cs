using System;

namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        { char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            PrintCharBetween(start, end);
            
            

           
        }
        static void PrintCharBetween(char firstChar, char secondChar)
        {

            char start;
            char end;
            if (firstChar < secondChar)
            {
                start = firstChar;
                end = secondChar;
            }
            else
            {
                start = secondChar;
                end = firstChar;
            }

            for (int i = start + 1; i < end; i++)
            {
                Console.Write((char)i + " ");
            }

        }
    }
}

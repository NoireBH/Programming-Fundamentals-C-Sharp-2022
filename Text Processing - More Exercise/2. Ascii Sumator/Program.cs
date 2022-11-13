using System;

namespace _2._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startingChar = char.Parse(Console.ReadLine());
            char endingChar = char.Parse(Console.ReadLine());
                string randomString = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < randomString.Length; i++)
            {
                if (randomString[i] > startingChar && randomString[i] < endingChar)
                {
                    sum += randomString[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}

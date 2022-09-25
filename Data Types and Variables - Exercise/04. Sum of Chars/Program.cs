using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                int valueCh = (int)ch;
                sum += ch;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}

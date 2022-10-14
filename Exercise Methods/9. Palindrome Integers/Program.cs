using System;
using System.Linq;

namespace _9._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {   
                int number = int.Parse(input);
                if (number <= 0)
                {
                    input = Console.ReadLine();
                    continue;
                }
                string reversed = Reverse(input);
                if (reversed == input)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();

               

            }

        }
        public static string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

using System;

namespace _7._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
            
        {   string input = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            string repeatResult = Repeat(input, number);
            Console.WriteLine(repeatResult);


            static string Repeat(string input, int number)
            {   string repeatResult = string.Empty;
                for (int i = 0; i < number; i++)
                {
                    repeatResult+= input;
                }
                return repeatResult;
            }
        }
    }
}

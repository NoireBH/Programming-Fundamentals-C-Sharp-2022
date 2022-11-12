using System;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine())!= "end")
            {
                string oldInput = input;
                string newinput = Reverse(input);

                Console.WriteLine($"{oldInput} = {newinput}");
            }
            

           
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

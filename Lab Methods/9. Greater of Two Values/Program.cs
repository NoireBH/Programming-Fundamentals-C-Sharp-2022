using System;

namespace _9._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();
            if (valueType == "int")
            {
                int firstInt = int.Parse(firstValue);
                int secontInt = int.Parse(secondValue);
                int result = GetMax(firstInt, secontInt);
                Console.WriteLine(result);
            }
            else if (valueType == "char")
            {
                char firstChar = char.Parse(firstValue);
                char secondChar = char.Parse(secondValue);
                char result = GetMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else if (valueType == "string")
            {
                string result = GetMax(firstValue, secondValue);
                Console.WriteLine(result);
            }

       }
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            
            
                return b;
            
        }
        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
           
                return b;
            
        }
        static string GetMax(string a, string b)
        {
            int result = a.CompareTo(b);
            if (result > 0)
            {
                return a;
            }
            return b;
        }
    }
}

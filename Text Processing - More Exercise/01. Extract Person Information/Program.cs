using System;
using System.Text;
namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLines; i++)
            {
                string text = Console.ReadLine();               
                int startOfName = text.IndexOf('@');
                int endOfName = text.IndexOf('|');
                string name = text.Substring(startOfName + 1, endOfName - startOfName - 1);
                int indexOfAgeStart = text.IndexOf('#');
                int indexOfAgeEnd = text.IndexOf('*');
                string ageStr = text.Substring(indexOfAgeStart + 1, indexOfAgeEnd - indexOfAgeStart - 1);
                Console.WriteLine($"{name} is {ageStr} years old.");   
            }
        }
    }
}

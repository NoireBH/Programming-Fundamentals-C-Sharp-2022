using System;
using System.Linq;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split();
            
            string[] evenArray = array
                .Where(X => X.Length % 2 == 0)
                .ToArray();
            foreach (var item in evenArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}

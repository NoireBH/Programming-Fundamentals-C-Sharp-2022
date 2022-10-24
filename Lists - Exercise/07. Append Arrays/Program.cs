using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine()
                                .Split('|')
                                .Reverse()
                                .ToList();
            List<int> result = new List<int>();
            foreach (string number in array)
            {
                result.AddRange(number.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList()
                         );
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}



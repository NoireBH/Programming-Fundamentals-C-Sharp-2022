using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            int n = Math.Min(firstList.Count, secondList.Count);
            for (int i = 0; i < n; i++)
            {
                int firstNum = firstList[i];
                int secondNum = secondList[i];
                result.Add(firstNum);
                result.Add(secondNum);

            }
            if (firstList.Count > secondList.Count)
            {
                for (int i = n; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                }
            }
            else if (secondList.Count > firstList.Count)
            {
                for (int i = n; i < secondList.Count; i++)
                {
                    result.Add(secondList[i]);
                }
            }
            Console.WriteLine(String.Join(" ", result));
            
        }
    }
}

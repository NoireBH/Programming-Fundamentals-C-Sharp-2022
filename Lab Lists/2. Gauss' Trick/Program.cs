using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> numbersAfterManipulation = new List<int>();
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int currentSum = numbers[i] + numbers[numbers.Count - 1 - i];
                numbersAfterManipulation.Add(currentSum);
            }
            if (numbers.Count % 2 != 0)
            {
                numbersAfterManipulation.Add(numbers[numbers.Count / 2]);
            }
            Console.WriteLine(String.Join(" ",numbersAfterManipulation));


        }
    }
}

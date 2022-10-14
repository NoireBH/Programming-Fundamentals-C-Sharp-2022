using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int givenNum = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numbers.Length; i++)
            {
                
                int currentNum = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nextNumber = numbers[j];
                    if (currentNum + nextNumber == givenNum )
                    {
                        Console.Write($"{currentNum} {nextNumber}");
                        Console.WriteLine();
                        break;
                    }
                }
            }
            

     }
    }
}

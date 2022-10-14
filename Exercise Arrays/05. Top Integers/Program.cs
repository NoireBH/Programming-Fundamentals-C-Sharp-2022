using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                bool isTop = true;

                for (int j = 1 + i; j < numbers.Length; j++)
                {       
                    int nextNumber = numbers[j];
                    if (nextNumber >= currentNumber)
                    {
                        isTop = false;
                        break;
                    }
                    
                }
                if (isTop)
                {
                    Console.Write(currentNumber + " ");
                }
            }
        }

    }
}

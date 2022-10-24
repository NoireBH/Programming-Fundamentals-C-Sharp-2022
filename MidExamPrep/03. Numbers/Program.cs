using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> allGreater = new List<int>();
            List<int> reversed = new List<int>();
           
            for (int i = 0; i < numbers.Count; i++)
            {
               
                if (numbers[i] > numbers.Average())
                { 
                    allGreater.Add(numbers[i]);                                 
                }
            }

            while (reversed.Count < 5 && allGreater.Count > 0)
            {
                reversed.Add(allGreater.Max());
                allGreater.Remove(allGreater.Max());
            }

                
            
            if (reversed.Any(X => X > numbers.Average()))
            {
                reversed.OrderByDescending(x => x).ToList();
                Console.WriteLine(String.Join(" ", reversed));
            }
            else
            {
                Console.WriteLine("No");
                
            }
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moves = 0;
            List<string> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            
            string command;
            while ((command = Console.ReadLine())!= "end" && numbers.Count != 0)
            {   
                int[] indexes =command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                moves++;
                if (indexes[0] == indexes[1] || indexes[0] < 0 || indexes[1] < 0 || indexes[0] >= numbers.Count || indexes[1] >= numbers.Count)
                {
                    numbers.Insert(numbers.Count / 2, $"-{moves}a");
                    numbers.Insert(numbers.Count / 2, $"-{moves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
               else if (numbers[indexes[0]] == numbers[indexes[1]])
                {
                    string element = numbers[indexes[0]];
                    Console.WriteLine($"Congrats! You have found matching elements - {numbers[indexes[0]]}!");
                    numbers.RemoveAll(e => e == element);

                }
                else
                {  
                    Console.WriteLine("Try again!");
                }


            }
            if (numbers.Count == 0)
            {
                Console.WriteLine($"You have won in {moves} turns!"); 
            }
            else
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
    }
}

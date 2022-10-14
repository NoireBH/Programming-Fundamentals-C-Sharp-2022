using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Ladybug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfFiled = int.Parse(Console.ReadLine());
            int[] startingLadyBugIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] ladyBugsArray = new int[sizeOfFiled];

            foreach (int index in startingLadyBugIndexes)
            {
                if (index >= 0 && index < sizeOfFiled)
                {
                    ladyBugsArray[index] = 1;
                }
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                int ladybugIndex = int.Parse(command[0]);
                string direction = command[1];
                int flyLength = int.Parse(command[2]);

                if (ladybugIndex < 0 || ladybugIndex >= ladyBugsArray.Length)
                {
                    continue;
                }

                if (ladyBugsArray[ladybugIndex] == 0)
                {
                    continue;
                }
                
                ladyBugsArray[ladybugIndex] = 0;

                if (direction == "left")
                {
                    flyLength *= -1; // turns the number into a negative 1 --> -1
                }
                int nextIndex = ladybugIndex + flyLength;

                while (nextIndex >= 0 && nextIndex < ladyBugsArray.Length && ladyBugsArray[nextIndex] == 1)
                {
                    nextIndex += flyLength;
                }
                if (nextIndex <0 || nextIndex >= ladyBugsArray.Length)
                {
                    continue;
                }
                ladyBugsArray[nextIndex] = 1;


            }
            Console.WriteLine(String.Join(" ", ladyBugsArray));
        }
    }
}

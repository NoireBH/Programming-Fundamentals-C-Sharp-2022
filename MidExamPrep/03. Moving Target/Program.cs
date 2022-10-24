using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(' ');
                string cmdArg = command[0];
                int index = int.Parse(command[1]);
                int value = int.Parse(command[2]);

                if (cmdArg == "Shoot")
                {
                    if (index < 0 || index >= targets.Count)
                    {
                        continue;
                    }
                    else
                    {
                        targets[index] -= value;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (cmdArg == "Add")
                {
                    if (index < 0 || index >= targets.Count)
                    {
                        Console.WriteLine("Invalid placement!");
                        continue;
                    }
                    else
                    {
                        targets.Insert(index, value);
                    }
                }
                else if (cmdArg == "Strike")
                {
                    if (index - value < 0 || index + value >= targets.Count)
                    {
                        Console.WriteLine("Strike missed!");
                        continue;
                    }
                    else
                    {
                        targets.RemoveRange(index - value, value * 2 + 1);
                    }
                }
            }
            Console.WriteLine(string.Join("|", targets));
        }
    }
}

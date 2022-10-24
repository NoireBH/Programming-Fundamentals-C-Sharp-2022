using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagon = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxPasseners = int.Parse(Console.ReadLine());
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                if (command[0] == "Add")
                {
                    wagon.Add(int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i < wagon.Count; i++)
                    {
                        if ((wagon[i] + int.Parse(command[0])) <= maxPasseners)
                        {
                            wagon[i] += int.Parse(command[0]);
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ", wagon));
        }
    }
}



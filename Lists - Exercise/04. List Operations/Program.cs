using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();

                if (command[0] == "Add")
                { int value = int.Parse(command[1]);
                    numbers.Add(value);
                }
                else if (command[0] == "Insert")
                {
                    int value = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    if (index >= numbers.Count || index <0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, value);
                }
                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);
                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(index);
                }
                else if (command[0] == "Shift" && command[1] == "left")
                {
                    int count = int.Parse(command[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int firstNum = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(firstNum);
                    }
                }
                else if (command[0] == "Shift" && command[1] == "right")
                {
                    int count = int.Parse(command[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int lastNum = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, lastNum);
                    }
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandToExecute = command.Split();
                int numberToExecute = int.Parse(commandToExecute[1]);


                if (commandToExecute[0] == "Add")
                {
                    numbers.Add(numberToExecute);
                }
               else if (commandToExecute[0] == "Remove")
                {
                    numbers.Remove(numberToExecute);
                }
               else if (commandToExecute[0] == "RemoveAt")
                {
                    numbers.RemoveAt(numberToExecute);
                }
              else  if (commandToExecute[0] == "Insert")
                {   int index = int.Parse(commandToExecute[2]);
                    numbers.Insert(index,numberToExecute);
                }

            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}

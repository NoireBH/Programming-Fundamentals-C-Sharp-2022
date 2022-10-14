using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._List_Manipulation_Advanced
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
            bool isChecked = false;
            while ((command = Console.ReadLine()) != "end")
            {   
                
                string[] commandToExecute = command.Split();
                


                if (commandToExecute[0] == "Add")
                {
                    int numberToExecute = int.Parse(commandToExecute[1]);
                    numbers.Add(numberToExecute);
                    isChecked = true;
                }
                else if (commandToExecute[0] == "Remove")
                {
                    int numberToExecute = int.Parse(commandToExecute[1]);
                    numbers.Remove(numberToExecute);
                    isChecked = true;
                }
                else if (commandToExecute[0] == "RemoveAt")
                {
                    int numberToExecute = int.Parse(commandToExecute[1]);
                    numbers.RemoveAt(numberToExecute);
                    isChecked = true;
                }
                else if (commandToExecute[0] == "Insert")
                {
                    int numberToExecute = int.Parse(commandToExecute[1]);
                    int index = int.Parse(commandToExecute[2]);
                    numbers.Insert(index, numberToExecute);
                    isChecked = true;
                }
                else if (commandToExecute[0] == "Contains")
                {
                    int numberToExecute = int.Parse(commandToExecute[1]);
                    if (numbers.Contains(numberToExecute))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (commandToExecute[0] == "PrintEven")
                {   
                    Console.WriteLine(String.Join(" ", numbers.Where(X => X % 2 == 0)));
                }
                else if (commandToExecute[0] == "PrintOdd")
                {
                    Console.WriteLine(String.Join(" ", numbers.Where(X => X % 2 != 0)));
                }
                else if (commandToExecute[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());

                }
                else if (commandToExecute[0] == "Filter")
                {   string condition = commandToExecute[1];
                    int value = int.Parse(commandToExecute[2]);
                    if (condition == "<")
                    {
                        Console.WriteLine(String.Join(" ", numbers.Where(X => X  < value)));
                    }
                    else if (condition == ">")
                    {
                        Console.WriteLine(String.Join(" ", numbers.Where(X => X > value)));
                    }
                    else if (condition == ">=")
                    {
                        Console.WriteLine(String.Join(" ", numbers.Where(X => X >= value)));
                    }
                    else if (condition == "<=")
                    {
                        Console.WriteLine(String.Join(" ", numbers.Where(X => X <= value)));
                    }
                }
            }
            if (isChecked)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
           
        }
    }
}

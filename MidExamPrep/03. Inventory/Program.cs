using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string cmd;
            while ((cmd = Console.ReadLine())!= "Craft!")
            {
                string[] command = cmd.Split(" - ");
                string arguement = command[0];
                string item = command[1];

                if (arguement == "Collect")
                {   
                    if (items.Contains(item))
                    {
                        continue;
                    }
                    else
                    {
                        items.Add(item);
                    }
                }
                else if (arguement == "Drop")
                {
                   
                    if (items.Any(X => X == item))
                    {
                        items.Remove(item);
                    }

                }
                else if (arguement == "Combine Items")
                {
                    string[] itemsToCombine = item.Split(":");

                    string oldItem = itemsToCombine[0];
                    string newItem = itemsToCombine[1];
                    int index = 0;
                    if (items.Any(X => X == oldItem))
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            if (items[i] == oldItem)
                            {
                                index = i;
                            }
                        }
                        items.Insert(index + 1, newItem);
                    }

                }
                else if (arguement == "Renew")
                {
                    
                    if (items.Any(X => X == item))
                    {
                        items.Remove(item);
                        items.Add(item);
                    }

                }
            }
            Console.WriteLine(string.Join(", ", items));
        }
    }
}

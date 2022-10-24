using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split('!')               
                .ToList();

            string command;
            while ((command = Console.ReadLine())!= "Go Shopping!")
            {
                string[] cmd  = command.Split();
                string arguement = cmd[0];
                string item = cmd[1];

                if (arguement == "Urgent")
                {
                    if (list.Contains(item))
                    {
                        continue;
                    }
                    else
                    {
                        list.Insert(0, item);
                    }
                    
                }
                else if (arguement == "Unnecessary")
                {
                    if (list.Contains(item))
                    {
                        list.Remove(item);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (arguement == "Correct")
                {
                    string oldItem = item;
                    string newItem = cmd[2];
                    if (list.Contains(oldItem))
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == oldItem)
                            {
                                list[i] = newItem;
                            }
                        }
                    }
                }
                else if (arguement == "Rearrange")
                {
                    if (list.Contains(item))
                    {
                        list.Add(item);
                        list.Remove(item);
                    }
                }
            }
            Console.WriteLine(String.Join(", ", list));


        }
    }
}

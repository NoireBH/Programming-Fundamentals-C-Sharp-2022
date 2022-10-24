using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Friend_List_Maintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> friendList = Console.ReadLine()
                .Split(", ")
                .ToList();
            int blacklistedNum = 0;
            int lostNamesNum = 0;
            string cmd;
            while ((cmd = Console.ReadLine()) != "Report")
            {
                
                
                string[] command = cmd.Split();
                string input = command[0];

                if (input == "Blacklist")
                {   
                    string name = command[1];

                    if (friendList.Contains(name))
                    {
                        for (int i = 0; i < friendList.Count; i++)
                        {
                            if (friendList[i] == name)
                            {   
                                Console.WriteLine($"{name} was blacklisted.");
                                friendList[i] = "Blacklisted";
                                blacklistedNum++;

                                
                            }
                        }

                    }
                    else if (friendList.All(X => X != name))
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                else if (input == "Error")
                {   
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < friendList.Count)
                    {
                        if (friendList[index] != "Blacklisted" && friendList[index] != "Lost")
                        {
                            Console.WriteLine($"{friendList[index]} was lost due to an error.");
                            friendList[index] = "Lost";
                            lostNamesNum++;
                        }
                        
                        
                    }
                   
                }
                else if (input == "Change")
                {
                    int index = int.Parse(command[1]);
                    string nameNew = command[2];
                    
                    if (index >= 0 && index < friendList.Count)
                    {
                        string currName = friendList[index];
                        if (friendList[index] != "Blacklisted" && friendList[index] != "Lost")
                        {
                            friendList[index] = nameNew;
                            Console.WriteLine($"{currName} changed his username to {nameNew}.");
                            
                        }
         

                    }
                }
            }

            Console.WriteLine($"Blacklisted names: {blacklistedNum}");
            Console.WriteLine($"Lost names: {lostNamesNum}");
            Console.WriteLine(String.Join(" ", friendList));

        }
    }
}

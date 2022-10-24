using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._Friend_List_Maintance_with_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friendList = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            int blacklistedNum = 0;
            int lostNamesNum = 0;
            string cmd;
            while ((cmd = Console.ReadLine()) != "Report" && friendList.Length > 0)
            {

                string[] command = cmd.Split();
                string input = command[0];

                if (input == "Blacklist")
                {
                    string name = command[1];
                    bool isFound = false;
                    for (int i = 0; i < friendList.Length; i++)
                    {
                        if (friendList[i] == name)
                        {
                            Console.WriteLine($"{name} was blacklisted.");
                            friendList[i] = "Blacklisted";
                            blacklistedNum++;
                            isFound = true;

                            break;
                        }

                    }
                    if (!isFound)
                    {
                        Console.WriteLine($"{name} was not found.");
                    }

                }

                else if (input == "Error")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index <= friendList.Length - 1)
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

                    if (index >= 0 && index <= friendList.Length - 1)
                    {
                        string currName = friendList[index];

                        friendList[index] = nameNew;
                        Console.WriteLine($"{currName} changed his username to {nameNew}.");
                        break;



                    }
                }
            }

            Console.WriteLine($"Blacklisted names: {blacklistedNum} ");
            Console.WriteLine($"Lost names: {lostNamesNum}");
            Console.WriteLine(String.Join(" ", friendList));

        }
    }
}





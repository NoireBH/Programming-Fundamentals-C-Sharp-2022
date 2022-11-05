using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registeredUsers = new Dictionary<string, string>();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {   
                string[] cmd = Console.ReadLine()
                    .Split();
                string command = cmd[0];

                if (command == "register")
                {
                    
                    string userName = cmd[1];
                    string licensePlateToRegister = cmd[2];
                    if (!registeredUsers.ContainsKey(userName))
                    {
                        registeredUsers.Add(userName, licensePlateToRegister);
                        Console.WriteLine($"{userName} registered {licensePlateToRegister} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateToRegister}");
                    }
                }

                else if (command =="unregister")
                {
                    string userNameToUnregister = cmd[1];
                   
                    if (!registeredUsers.ContainsKey(userNameToUnregister))
                    {
                        Console.WriteLine($"ERROR: user {userNameToUnregister} not found");
                    }
                    else
                    {
                        registeredUsers.Remove(userNameToUnregister);
                        Console.WriteLine($"{userNameToUnregister} unregistered successfully");
                    }
                }
                
            }

            foreach (var user in registeredUsers)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}

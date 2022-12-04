using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Messages_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = new SortedDictionary<string, UserMessages>();
            List<string> usersThatExist = new List<string>();
            int capacityOfMessages = int.Parse(Console.ReadLine());

            string input;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] cmd = input.Split("=");
                string command = cmd[0];

                if (command == "Add")
                {   
                    string username = cmd[1];
                    int sentMessages = int.Parse(cmd[2]);
                    int receivedMessages = int.Parse(cmd[3]);

                    if (!users.ContainsKey(username))
                    {
                        UserMessages userMessages = new UserMessages(sentMessages, receivedMessages);
                        users.Add(username, userMessages);
                        usersThatExist.Add(username);
                    }
                }

                else if (command == "Message")
                {
                    string sender = cmd[1];
                    string receiver = cmd[2];

                    if (users.ContainsKey(sender) && users.ContainsKey(receiver))
                    {
                        users[sender].SentMessages++;

                        if (users[sender].SentMessages + users[sender].ReceivedMessages >= capacityOfMessages)
                        {
                            Console.WriteLine($"{sender} reached the capacity!");
                            users.Remove(sender);
                            usersThatExist.Remove(sender);
                        }

                        users[receiver].ReceivedMessages++;

                        if (users[receiver].SentMessages + users[receiver].ReceivedMessages >= capacityOfMessages)
                        {
                            Console.WriteLine($"{receiver} reached the capacity!");
                            users.Remove(receiver);
                            usersThatExist.Remove(receiver);
                        }
                   
                    }

                }

                else if (command == "Empty")
                {
                    string username = cmd[1];

                    if (username == "All")
                    {
                        users.Clear();
                        usersThatExist.Clear();
                    }

                    else if (users.ContainsKey(username))
                    {
                        users.Remove(username);
                        usersThatExist.Remove(username);
                    }
                }
            }

            Console.WriteLine($"Users count: {users.Count}");

            foreach (var user in usersThatExist)
            {
                Console.WriteLine($"{user} - {users[user].ReceivedMessages + users[user].SentMessages}");
            }

        }

        class UserMessages
        {
            public UserMessages(int sentMessages, int receivedMessages)
            {
                SentMessages = sentMessages;
                ReceivedMessages = receivedMessages;
            }

            public int SentMessages { get; set; }
            public int ReceivedMessages { get; set; }

        }
    }
}

using System;
using System.Linq;

namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] cmd = input.Split(":|:");
                string command = cmd[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(cmd[1]);
                    concealedMessage = concealedMessage.Insert(index, " ");
                    Console.WriteLine(concealedMessage);
                }


                else if (command == "Reverse")
                {
                    string subStr = cmd[1];
                    if (concealedMessage.Contains(subStr))
                    {
                        int index = concealedMessage.IndexOf(subStr);
                       concealedMessage = concealedMessage.Remove(index, subStr.Length);
                        char[] charArray = subStr.ToCharArray();
                        Array.Reverse(charArray);
                       string reversed =  new string(charArray);
                        concealedMessage = concealedMessage + reversed;
                        Console.WriteLine(concealedMessage);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    
                }

                else if (command == "ChangeAll")
                {
                    string subStr = cmd[1];
                    string replacement = cmd[2];
                    concealedMessage = concealedMessage.Replace(subStr, replacement);
                    Console.WriteLine(concealedMessage);
                }
            }
            Console.WriteLine($"You have a new text message: {concealedMessage}");

        }
    }
}

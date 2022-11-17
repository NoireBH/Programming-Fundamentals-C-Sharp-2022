using System;
using System.Text;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            var decryptedMessage = new StringBuilder();
            decryptedMessage.Append(encryptedMessage);
            string cmd;

            while ((cmd = Console.ReadLine()) != "Decode")
            {
                string[] commandAndArguement = cmd.Split('|');
                string command = commandAndArguement[0];
                if (command == "Move")
                {
                    int numberOfMoves = int.Parse(commandAndArguement[1]);

                    string subStr = decryptedMessage.ToString().Substring(0, numberOfMoves);
                    decryptedMessage.Remove(0, subStr.Length);
                    decryptedMessage.Append(subStr);


                }


                else if (command == "Insert")
                {
                    int index = int.Parse(commandAndArguement[1]);
                    string value = commandAndArguement[2];
                    decryptedMessage.Insert(index, value);

                }

                else if (command == "ChangeAll")
                {
                    string substring = commandAndArguement[1];
                    string replacement = commandAndArguement[2];
                    if (encryptedMessage.Contains(substring))
                    {
                        encryptedMessage = decryptedMessage.ToString().Replace(substring, replacement);
                        decryptedMessage = new StringBuilder(encryptedMessage);

                    }
                }
               
            }

            Console.WriteLine($"The decrypted message is: {decryptedMessage}");
        }
    }
}

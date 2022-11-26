using System;
using System.Text;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder encryptedMessage = new StringBuilder(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] cmd = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string command = cmd[0];

                if (command == "Move")
                {
                    int lettersMovedNum = int.Parse(cmd[1]);
                    string substring = encryptedMessage.ToString().Substring(0, lettersMovedNum);

                    encryptedMessage.Remove(0, substring.Length);
                    encryptedMessage.Append(substring);
                }

                else if (command == "Insert")
                {
                    int index = int.Parse(cmd[1]);
                    string value = cmd[2];

                    encryptedMessage.Insert(index, value);
                }

                else if (command == "ChangeAll")
                {
                    string substring = cmd[1];
                    string replacement = cmd[2];
                    encryptedMessage.Replace(substring, replacement);
                }
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}

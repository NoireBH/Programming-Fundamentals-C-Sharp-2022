using System;
using System.Linq;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            

            foreach (var username in usernames)
            {
                if (isValidUsername(username))
                {
                    Console.WriteLine(username);
                }
            }
        }

        private static bool isValidUsername(String username)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }

            for (int i = 0; i < username.Length; i++)
            {
                char symbol = username[i];

                if (!Char.IsLetterOrDigit(symbol) && symbol != '-' && symbol != '_')
                {
                    return false;
                }
            }

            return true;
        }
    }
}

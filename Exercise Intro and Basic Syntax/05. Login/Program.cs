using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            int totalTries = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char currentChar = username[i];    
                password += currentChar;
                
                

            }
            string currentPassword;
            while ((currentPassword = Console.ReadLine()) != password)
            {
                totalTries++;
                
                if (totalTries >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");

            }
            if (totalTries < 4 && currentPassword == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}

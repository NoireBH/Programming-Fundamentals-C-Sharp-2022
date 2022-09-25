using System;

namespace _3._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 0;
            double totalSpent = 0;
            double balance = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "Game Time")
            {
             
               
                if (command == "OutFall 4")
                {
                    price = 39.99;
                     totalSpent += price;
                }
                else if (command == "Zplinter Zell")
                {
                    price = 19.99;
                     totalSpent += price;
                }
                else if (command == "CS: OG")
                {
                    price = 15.99;
                    totalSpent += price;
                }
                else if (command == "Honored 2")
                {
                    price = 59.99;
                     totalSpent += price;
                }
                else if (command == "RoverWatch")
                {
                    price = 29.99;
                     totalSpent += price;
                }
                else if (command == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                     totalSpent += price;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    price = 0;
                    command = Console.ReadLine();
                    continue;
                }
                if (balance < price)
                {
                    Console.WriteLine("Too Expensive");
                    price = 0;
                }
                else if (balance >= price)
                {
                    Console.WriteLine($"Bought {command}");
                    balance -= price;
                }
                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                command = Console.ReadLine();   
            }
            if (balance > 0)
            {
                Console.Write($"Total spent: ${totalSpent:f2}. ");
                Console.Write($"Remaining: ${balance:f2}");
            }
            

        }
    }
}

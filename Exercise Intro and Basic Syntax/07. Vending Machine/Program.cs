using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double money = 0;
            double productPrice = 0;
            while (command != "Start")
            {
                double coin = double.Parse(command);
                if (coin == 0.1 )
                {
                    money += coin;
                }
                else if (coin == 0.2)
                {
                    money += coin;
                }
                else if (coin == 0.5)
                {
                    money += coin;
                }
                else if (coin == 1)
                {
                    money += coin;
                }
                else if (coin == 2)
                {
                    money += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }


                command = Console.ReadLine();
            }
            while (command != "End")
            {
                if (command == "Start")
                {
                    command = Console.ReadLine();   
                }
                
                if (command == "Nuts")
                {
                    productPrice = 2;
                }
                else if (command == "Water")
                {
                    productPrice = 0.7;
                }
                else if (command == "Crisps")
                {
                    productPrice = 1.5;
                }
                else if (command == "Soda")
                {
                    productPrice = 0.8;
                }
                else if (command == "Coke")
                {
                    productPrice = 1;
                }
                
                else 
                {
                    Console.WriteLine("Invalid product");
                    command = Console.ReadLine();   
                    continue;
                }
                if (money >= productPrice)
                {
                    money -= productPrice;
                    Console.WriteLine($"Purchased {command.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                    
                }
                if (money == 0)
                {
                    break;
                }
                command = Console.ReadLine();

            }
            Console.WriteLine($"Change: {money:f2}");
        }
    }
}

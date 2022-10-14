using System;

namespace _3._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Calculations(command, number, number2);
            

        }

         static void Calculations(string command, int number, int number2)
        {
            if (command == "add")
            {
                Console.WriteLine(number + number2);
                
            }
            else if (command == "multiply")
            {
                Console.WriteLine(number * number2); 
            }
            else if (command == "subtract")
            {
                Console.WriteLine(number - number2); 
            }
            else if (command == "divide")
            {
                Console.WriteLine(number / number2);
            }
        }
    }
}

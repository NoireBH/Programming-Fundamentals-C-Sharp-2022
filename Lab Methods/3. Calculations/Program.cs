using System;

namespace _3._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string typeOfCommand = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
          int result = Calculate(typeOfCommand, a, b);
            Console.WriteLine(result);
        }

        public static int Calculate(string typeOfCommand, int a ,int b)
        {
            int result = 0;
            switch (typeOfCommand)
            {
                case "add":
                     result = a + b;
                    break;
                case "subtract":
                    result = a - b;
                    break;
                case "multiply":
                    result = a * b;
                    break;
                case "divide":
                    result = a / b;
                    break;              
            }
            return result;
        }
    }
}

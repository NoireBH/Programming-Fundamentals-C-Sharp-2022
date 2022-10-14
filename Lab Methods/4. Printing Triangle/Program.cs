using System;

namespace _4._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <=number; i++) // rows
            {
                printColumns(i);
            }
            for (int i = number - 1; i >= 1; i--) // rows
            {
                printColumns(i);
            }
            
           


        }

        private static void printColumns(int i)
        {
            for (int j = 1; j <= i; j++) // columns
            {
                Console.Write(j + " ");
                
            }
            Console.WriteLine();
        }
    }
}

using System;

namespace _1._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            numberChecker(int.Parse(Console.ReadLine()));
        }

        private static void numberChecker(int number)
        {
            
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative. ");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero. ");
            }
        }
    }
}

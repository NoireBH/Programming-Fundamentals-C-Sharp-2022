using System;

namespace _2._Passed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            if (number >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}

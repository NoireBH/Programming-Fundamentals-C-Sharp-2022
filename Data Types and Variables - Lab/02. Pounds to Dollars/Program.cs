using System;

namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double british = double.Parse(Console.ReadLine());
            double dollars = british * 1.31;
            Console.WriteLine($"{dollars:F3}");
        }
    }
}

using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());

            int result1 = n1 + n2;
            int result2 = result1 / n3;
            int result3 = result2 * n4;
            Console.WriteLine(result3);
        }
    }
}

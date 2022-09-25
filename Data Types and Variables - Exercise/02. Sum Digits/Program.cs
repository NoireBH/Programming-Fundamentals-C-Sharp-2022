using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int copy = n;
            int sum = 0;
            while (copy > 0)
            {
                sum += copy % 10;
                copy /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}

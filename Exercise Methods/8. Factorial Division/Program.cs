using System;

namespace _8._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            double factorialdivision = GetFactorial(n1) * 1.0 / GetFactorial(n2);
            Console.WriteLine($"{factorialdivision:f2}");

            


        }
        static long GetFactorial(int n)
        {
            long factorial = n;
            for (int i = n; i > 1; i--)
            {
                factorial *= (i - 1);
            }
            return factorial;
        }
    }
}

using System;

namespace _5._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int sum = GetSumOfFirstTwoNums(n1, n2);
            int substraction = SubtractSumAndThirdNum(sum, n3);
            Console.WriteLine(substraction);

        }
         static int GetSumOfFirstTwoNums (int n1, int n2)
        {
            int sum = n1 + n2;
            return sum;
        }
        static int SubtractSumAndThirdNum(int sum, int n3)
        {
            int substraction = sum - n3;
            return substraction;
        }
    }
}

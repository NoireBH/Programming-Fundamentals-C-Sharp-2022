using System;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] people = new int[n];
            int sum = 0;

            for (int i = 0; i < people.Length ; i++)
            {
                int currentWagon = int.Parse(Console.ReadLine());
                people[i] = currentWagon;
                sum += people[i];
                Console.Write($"{people[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}

using System;

namespace _7._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        { int n = int.Parse(Console.ReadLine());
            PrintNxNMatrix(n);
        }
        static void PrintNxNMatrix(int n)
        {
            for (int i = 0; i <n; i++) // rows
            {
                
                for (int j = 0; j < n; j++) //columns
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}

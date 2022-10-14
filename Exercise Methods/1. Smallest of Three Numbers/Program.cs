using System;

namespace _1._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {//Create a method that prints out the smallest of three integer numbers.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int smallest = smallestNumber(a, b, c);
            Console.WriteLine(smallest);





        }
        static int smallestNumber(int a, int b, int c)
        {
            int smallest = 0;
            if (a < b && a < c)
            {
                smallest = a;
            }
            else if (b < a && b < c)
            {
                smallest = b;
            }
            else
            {
                smallest = c;   
            }
            return smallest;

        }
    }
}

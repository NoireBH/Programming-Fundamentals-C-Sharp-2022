using System;

namespace _2._English_Name_of_the_Last_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
           int n2 = n % 10;
            if (n2 == 1)
            {
                Console.WriteLine("one");
            }
            else if (n2 == 2)
            {
                Console.WriteLine("two");
            }
            else if (n2 == 3)
            {
                Console.WriteLine("three");
            }
            else if (n2 == 4)
            {
                Console.WriteLine("four");
            }
            else if (n2 == 5)
            {
                Console.WriteLine("five");
            }
            else if (n2 == 6)
            {
                Console.WriteLine("six");
            }
            else if (n2 == 7)
            {
                Console.WriteLine("seven");
            }
            else if (n2 == 8)
            {
                Console.WriteLine("eight");
            }
            else if (n2 == 9)
            {
                Console.WriteLine("nine");
            }
            else if (n2 == 0)
            {
                Console.WriteLine("zero");
            }
        }   
    }
}

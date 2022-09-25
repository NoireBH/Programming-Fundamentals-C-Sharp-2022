using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacityOfTank = 255;
            int litresInTank = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                
                    int litres = int.Parse((Console.ReadLine()));
                    litresInTank += litres;
                    if (capacityOfTank < litresInTank)
                    {
                        litresInTank -= litres;
                        Console.WriteLine("Insufficient capacity!");
                        continue;
                    }             
            }
            Console.WriteLine(litresInTank);

        }
    }
}

using System;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());
            double singleCoffeePrice = 0;
            double total = 0;

            for (int i = 1; i <= countOfOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());
                singleCoffeePrice = ((days * capsuleCount) * pricePerCapsule);
                total += singleCoffeePrice;
                Console.WriteLine($"The price for the coffee is: ${singleCoffeePrice:f2}");
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}

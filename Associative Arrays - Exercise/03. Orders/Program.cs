using System;
using System.Collections.Generic;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Dictionary<string, PriceAndQuantityOfOrder> orders = new Dictionary<string, PriceAndQuantityOfOrder>();

            string input;

            while ((input = Console.ReadLine())!= "buy")
            {
                string[] data = input.Split();
                string name = data[0];
                double price = double.Parse(data[1]);
                double quantity = double.Parse(data[2]);
                PriceAndQuantityOfOrder priceAndQuality = new PriceAndQuantityOfOrder(price, quantity);

                if (!orders.ContainsKey(name))
                {   
                    orders.Add(name, priceAndQuality);
                    
                    
                }

                else
                {
                    orders[name].Price = price;
                    orders[name].Quanity += quantity;
                }

            }

            foreach (var order in orders)
            {
                Console.WriteLine($"{order.Key} -> {(order.Value.Price * order.Value.Quanity):f2}");
            }
        }
        class PriceAndQuantityOfOrder
        {
          public  PriceAndQuantityOfOrder(double price , double quantity)
            {
                Price = price;
                Quanity = quantity;
            }
            public double Price { get; set; }
            public double Quanity { get; set; }
        }

    }
}

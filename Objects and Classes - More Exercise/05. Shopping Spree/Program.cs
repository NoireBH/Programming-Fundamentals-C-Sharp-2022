using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Shopping_Spree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            string[] inputPeople = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] inputProducts = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in inputPeople)
            {
                string[] personInfo = item.Split("=");
                Person person = new Person(personInfo[0], double.Parse(personInfo[1]));
                people.Add(person);
            }
            foreach (var item in inputProducts)
            {
                string[] productInfo = item.Split('=');
                Product product = new Product(productInfo[0], double.Parse(productInfo[1]));
                products.Add(product);
            }
            string input;
            while ((input = Console.ReadLine())!= "END")
            {
                string[] data = input.Split();
                string PersonThatIsBuying = data[0];
                string itemToBuy = data[1];

                Person person = people
                    .Where(X => X.Name == PersonThatIsBuying)
                    .First();
                Product product = products
                    .Where(X => X.Name == itemToBuy)
                    .First();
                if (person.Money - product.Cost >= 0)
                {
                    person.Products.Add(product);
                    person.Money -= product.Cost;
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");

                }

                
            }

            foreach (var currentPerson in people)
            {
                Console.Write($"{currentPerson.Name} - ");
                if (currentPerson.Products.Count > 0)
                {
                    List<string> productsNames = new List<string>();
                    foreach (var currentProduct in currentPerson.Products)
                    {
                        productsNames.Add(currentProduct.Name);
                    }

                    Console.WriteLine(string.Join(", ", productsNames));
                }
                else
                {
                    Console.WriteLine("Nothing bought");
                }
            }
        }
    }
    class Person
    {
      public Person(string name, double money)
        {
            Name = name;
            Money = money;
            Products = new List<Product>();
        }

        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> Products { get; set; }
        
        
    }
    class Product
    {
       public Product(string name, double cost)
        {
            Name =name;
            Cost = cost;
        }
        public string Name { get; set; }
        public double Cost { get; set; }
       
    }
}

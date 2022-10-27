using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        List<Car> cars = new List<Car>();
        List<Truck> trucks = new List<Truck>();
        static void Main(string[] args)
        {
            string input;
            Catalog catalog = new Catalog();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] parts = input.Split("/");
                string vehicleType = parts[0];
                string brand = parts[1];
                string model = parts[2];
                int value = int.Parse(parts[3]);

                if (vehicleType == "Car")
                {
                    Car car = new Car(brand, model, value);
                    catalog.Cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck(brand, model, value);
                    catalog.Trucks.Add(truck);
                }

            }
            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
            }
            

            foreach (var car in catalog.Cars.OrderBy(X=> X.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower }hp");
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
            }
            
            foreach (var truck in catalog.Trucks.OrderBy(X => X.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
        class Catalog
        {
            public Catalog()
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }
            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }

        }

    }
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

    }
    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }

    }
}


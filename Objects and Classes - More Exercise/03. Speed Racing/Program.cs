using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] data = Console.ReadLine()
                    .Split();
                string model = data[0];
                double fuel = double.Parse(data[1]);
                double fuelConsumptionPerKM = double.Parse(data[2]);
                Car car = new Car(model, fuel , fuelConsumptionPerKM);              
                cars.Add(car);

                

            }
            string input;
            while ((input = Console.ReadLine())!= "End")
            {
                string[] data = input
                    .Split()
                    .ToArray();
                string CarModel = data[1];
                double amountOfKM = int.Parse(data[2]);

                Car carsToDrive = cars
                        .Where(x => x.Model == CarModel)                        
                        .First();

                carsToDrive.CanITravelThisDistance(CarModel, amountOfKM);

            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:f2} {car.TraveledDistance}");
            }

        }
       

        class Car
        {
           public Car(string model, double fuel , double fuelConsumptionPerKM)
            {
                Model = model;
                Fuel = fuel;
                FuelConsumptionPerKM = fuelConsumptionPerKM;
                TraveledDistance = 0;
                
            }

            public void CanITravelThisDistance(string model , double amountOfKM)
            {
                double neededLitres = FuelConsumptionPerKM * amountOfKM;

                if (Fuel >= neededLitres)
                {
                    Fuel -= neededLitres;
                    TraveledDistance += amountOfKM;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }
            
            public string Model { get; set; }
            public double Fuel { get; set; }
            public double FuelConsumptionPerKM { get; set; }

            public double TraveledDistance { get; set; }


        }
    }
}

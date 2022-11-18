using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] infoAboutCars = Console.ReadLine()
                    .Split("|");
                string carName = infoAboutCars[0];
                double mileage = double.Parse(infoAboutCars[1]);
                double fuel = double.Parse(infoAboutCars[2]);

                if (!cars.Any(x => x.CarName == carName))
                {
                    Car car = new Car(carName, mileage, fuel);
                    cars.Add(car);
                }
            }
            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] cmd = input.Split(" : ");
                string command = cmd[0];
                string car = cmd[1];

                if (command == "Drive")
                {
                    double distance = double.Parse(cmd[2]);
                    double fuelUsed = double.Parse(cmd[3]);

                    foreach (var item in cars)
                    {
                        if (item.CarName == car)
                        {
                            if (item.Fuel >= fuelUsed)
                            {
                                item.Fuel -= fuelUsed;
                                item.Mileage += distance;
                                Console.WriteLine($"{car} driven for {distance} kilometers. {fuelUsed} liters of fuel consumed.");
                            }

                            else
                            {
                                Console.WriteLine("Not enough fuel to make that ride");
                            }

                            if (item.Mileage >= 100000)
                            {
                                cars.Remove(item);
                                Console.WriteLine($"Time to sell the {car}!");
                            }
                            break;
                        }
                    }

                }

                else if (command == "Refuel")
                {       
                    double fuelRefuel = double.Parse(cmd[2]);
                    foreach (var item in cars)
                    {
                        
                        if (item.CarName == car)
                        {
                            item.Fuel += fuelRefuel;
                            if (item.Fuel > 75)
                            {
                                Console.WriteLine($"{car} refueled with { fuelRefuel + 75 - item.Fuel} liters");
                                item.Fuel = 75;
                                
                            }
                            else
                            {
                                
                                Console.WriteLine($"{car} refueled with {fuelRefuel} liters");
                            }
                            
                            break;
                        }
                    }
                }

                else if (command == "Revert")
                {
                    double kilometers = double.Parse(cmd[2]);

                    foreach (var item in cars)
                    {
                        if (item.CarName == car)
                        {
                            item.Mileage -= kilometers;
                            if (item.Mileage >= 10000)
                            {
                                Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                            }
                            
                            if (item.Mileage < 10000)
                            {
                                item.Mileage = 10000;
                            }
                            break;
                        }
                        
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.CarName} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }
        class Car
        {
            public Car(string carName, double mileage, double fuel)
            {
                CarName = carName;
                Mileage = mileage;
                Fuel = fuel;
            }
            public string CarName { get; set; }
            public double Mileage { get; set; }
            public double Fuel { get; set; }

        }
    }
}

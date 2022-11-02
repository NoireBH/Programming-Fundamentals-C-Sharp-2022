using System;
using System.Collections.Generic;

namespace _04._Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {   
                string[] data = Console.ReadLine()
                    .Split();
                string model = data[0];
                int engineSPeed = int.Parse(data[1]);
                int enginePower = int.Parse(data[2]);
                int cargoWeight = int.Parse(data[3]);
                string cargoType = data[4];
                Engine engine = new Engine(engineSPeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(model, engine, cargo);
                cars.Add(car);

            }
            string typeOfCargoToPrint = Console.ReadLine();

            foreach (Car car in cars)
            {
                if (typeOfCargoToPrint == "fragile")
                {
                    if (car.Cargo.Type == typeOfCargoToPrint && car.Cargo.Weight < 1000)
                    {
                        Console.WriteLine($"{car.Model}");
                    }
                }
                else if (typeOfCargoToPrint == "flamable" )
                {
                    if (car.Cargo.Type == typeOfCargoToPrint && car.Engine.Power > 250)
                    {
                        Console.WriteLine($"{car.Model}");
                    }
                }
            }
        }
    }
    class Car
    {   
        public Car(string model , Engine engine , Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;

        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

    }
    class Engine
    {   
        public Engine(int engineSpeed , int enginePower)
        {
            this.Speed = engineSpeed;
            this.Power = enginePower;
        }
        public int Speed { get; set; }
        public int Power { get; set; }
        
    }
    class Cargo
    { 
        public Cargo(int cargoWeight, string cargoType)
        {
            this.Weight = cargoWeight;
            this.Type = cargoType;
        }
        public int Weight { get; set; }
        public string Type { get; set; }
    }
}

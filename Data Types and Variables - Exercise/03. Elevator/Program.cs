using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());

            int timesNeeded = peopleCount / capacityOfElevator;
            if (peopleCount % capacityOfElevator != 0)
            {
                timesNeeded++;
            }
            Console.WriteLine(timesNeeded);
        }
    }
}

using System;
using System.Linq;

namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] wagon = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < wagon.Length; i++)
            {
                if (people <= 0)
                {
                    break;
                }
                while (wagon[i] < 4)
                {
                    if (people <= 0)
                    {
                        break;
                    }
                    wagon[i]++;
                   
                    people--;
                }
            }
            if (people > 0 && wagon.All(x => x == 4))
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(String.Join(" ", wagon));
            }
            else if(people <= 0 && wagon.Any(x => x < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(String.Join(" ", wagon));
            }
           else if (people == 0 && wagon.All(x => x == 4))
            {
                
                Console.WriteLine(String.Join(" ", wagon));
            }
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._Pokemon_Don_t_go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> distanceToPokemon = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> capturedPokemon = new List<int>();

            while (distanceToPokemon.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int removedElementValue = 0;
                if (index < 0)
                {
                    int lastPokemon = distanceToPokemon[distanceToPokemon.Count - 1];
                    removedElementValue = distanceToPokemon[0];
                    capturedPokemon.Add(distanceToPokemon[0]);
                    distanceToPokemon.RemoveAt(0);
                    distanceToPokemon.Insert(0, lastPokemon);
                   
                }
                else if (index >= 0 && index <= distanceToPokemon.Count - 1)
                {
                     removedElementValue = distanceToPokemon[index];
                    capturedPokemon.Add(removedElementValue);
                    distanceToPokemon.RemoveAt(index);
                }
                else if (index > distanceToPokemon.Count - 1)
                {
                    int firstPokemon = distanceToPokemon[0];
                    removedElementValue = distanceToPokemon[distanceToPokemon.Count - 1];
                    capturedPokemon.Add(distanceToPokemon[distanceToPokemon.Count - 1]);
                    distanceToPokemon.RemoveAt(distanceToPokemon.Count - 1);
                    distanceToPokemon.Add(firstPokemon);
                }
              

                for (int i = 0; i < distanceToPokemon.Count; i++)
                {
                    if (distanceToPokemon[i] <= removedElementValue)
                    {
                        distanceToPokemon[i] += removedElementValue;
                    }
                    else if (distanceToPokemon[i] > removedElementValue)
                    {
                        distanceToPokemon[i] -= removedElementValue;
                    }
                }


            }
            Console.WriteLine(String.Join(" ", capturedPokemon.Sum()));
        }
    }
}

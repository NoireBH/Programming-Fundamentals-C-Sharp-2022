using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string command;
            int shotTargets = 0;
            while ((command = Console.ReadLine())!= "End")
            {
                int index = int.Parse(command);
                
                if (index >= 0 && index <= targets.Length - 1) //check if it's possible to shoot index
                {
                    if (targets[index] != -1) //check if already shot
                    {
                        for (int i = 0; i < targets.Length; i++) //check for higher or lower value
                        {
                            if (targets[i] > targets[index] && i != index)
                            {
                                if (targets[i] != - 1)
                                {
                                    targets[i] -= targets[index];
                                }
                                    
                            }
                            else if (targets[i] <= targets[index] && i != index)
                            {
                                if (targets[i] != - 1)
                                {
                                    targets[i] += targets[index];
                                }
                                
                            }
                        }
                        targets[index] = -1; // shot
                        shotTargets++;
                       
                    }

                }
            }
            Console.Write($"Shot targets: {shotTargets} -> ");
            Console.WriteLine(String.Join(" ",targets));
        }
    }
}

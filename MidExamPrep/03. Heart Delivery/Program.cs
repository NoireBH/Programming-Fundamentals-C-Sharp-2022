using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToList();
            string cmd;
            int lastPosition = 0;
            
            while ((cmd = Console.ReadLine()) != "Love!")
            {
                string[] parts = cmd.Split(' ');
                int lengthOfJump = int.Parse(parts[1]);              
                if (lengthOfJump + lastPosition > houses.Count - 1)
                {
                    lastPosition = 0;
                    lengthOfJump = 0;
                }
                if (lengthOfJump + lastPosition <= houses.Count)
                {   
                    

                        if (houses[lengthOfJump + lastPosition] <= 0)
                        {
                            lastPosition = lengthOfJump + lastPosition;
                            Console.WriteLine($"Place {lastPosition} already had Valentine's day.");

                        }
                        else
                        {
                            
                            houses[lengthOfJump + lastPosition] -= 2;
                        lastPosition = lengthOfJump + lastPosition;
                        if (houses[lastPosition] <= 0)
                            {
                                Console.WriteLine($"Place {lastPosition} has Valentine's day.");
                            }
                        }


                    
                }


            }
            Console.WriteLine($"Cupid's last position was {lastPosition}.");
            if (houses.All(X => X <= 0))
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int failCount = 0;
                for (int i = 0; i < houses.Count; i++)
                {   
                    if (houses[i] > 0)
                    {
                        failCount++;
                    }
                }
                Console.WriteLine($"Cupid has failed {failCount} places.");
            }
        }
    }
}

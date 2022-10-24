using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Card_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOneHand = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> playerTwoHand = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int sum = 0;
            while (playerOneHand.Count > 0 && playerTwoHand.Count >0)
            {
                if (playerOneHand[0] > playerTwoHand[0])
                {
                    playerOneHand.Add(playerOneHand[0]);
                    playerOneHand.Add(playerTwoHand[0]);
                }
                else if (playerTwoHand[0] > playerOneHand[0])
                {
                    playerTwoHand.Add(playerTwoHand[0]);
                    playerTwoHand.Add(playerOneHand[0]);
                }
                playerOneHand.Remove(playerOneHand[0]);
                playerTwoHand.Remove(playerTwoHand[0]);
            }
            if (playerOneHand.Count == 0)
            {
                sum = playerTwoHand.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            else if (playerTwoHand.Count == 0)
            {
                sum = playerOneHand.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }


        }
    }
}

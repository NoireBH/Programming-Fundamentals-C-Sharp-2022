using System;

namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scissors";
            Console.Write("Choose rock, paper or scissors: ");
            string PlayerMove = Console.ReadLine();
            if (PlayerMove == "r" || PlayerMove == "rock" || PlayerMove == "Rock")
            {
                PlayerMove = rock;
            }
            else if (PlayerMove == "p" || PlayerMove == "paper" || PlayerMove == "Paper")
            {
                PlayerMove = paper;
            }
            else if (PlayerMove == "s" || PlayerMove == "scissors" || PlayerMove == scissors)
            {
                PlayerMove = scissors;
            }
            else
            {
                Console.WriteLine("Invalid Input. Please try again...");
                return;
            }
            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerMove = string.Empty;
            switch (computerRandomNumber)
            {
                case 1:
                    computerMove = rock;       
                    break;
                    case 2:
                    computerMove = paper;
                    break;
                case 3:
                    computerMove = scissors;
                    break;
                   
            }
            Console.WriteLine($"The computer threw {computerMove}");
            if (PlayerMove == rock && computerMove == scissors || PlayerMove == paper && computerMove == rock || PlayerMove == scissors && computerMove == paper)
            {
                Console.WriteLine("You win");
            }
            else if (PlayerMove == computerMove)
            {
                Console.WriteLine("draw");
            }
            else if (PlayerMove == rock && computerMove == paper || PlayerMove == paper && computerMove == scissors || PlayerMove == scissors && computerMove == rock)
            {
                Console.WriteLine("You lose");
            }






        }
    }
}

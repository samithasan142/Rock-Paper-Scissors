using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int playerScore = 0;
            int opponentScore = 0;

            Console.WriteLine("Welcome to Rock Paper Scissors!");

            while(playerScore != 3 && opponentScore != 3)
            {
                Console.WriteLine("Player score: " + playerScore + ". Opponent score: " + opponentScore);
                Console.WriteLine("Please enter 'r' for rock, 'p' for paper or anything else for scissors");

                string playerChoice = Console.ReadLine();
                int opponentChoice = random.Next(0, 3);

                if(opponentChoice == 0)
                {
                    Console.WriteLine("Opponent chooses rock.");

                    switch(playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie!");
                            break;
                        case "p":
                            Console.WriteLine("Player wins this round.");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("Opponent wins this round.");
                            opponentScore++;
                            break;
                    }
                }
                else if(opponentChoice == 1)
                {
                    Console.WriteLine("Opponent chooses paper.");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Opponent wins this round.");
                            opponentScore++;
                            break;
                        case "p":
                            Console.WriteLine("Tie!");
                            break;
                        default:
                            Console.WriteLine("Player wins this round");
                            playerScore++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opponent chooses scissors.");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player wins this round.");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("Opponent wins this round.");
                            opponentScore++;
                            break;
                        default:
                            Console.WriteLine("Tie!");
                            break;
                    }
                }
            }
            
            if(playerScore == 3)
            {
                Console.WriteLine("You win!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You lose!");
                Console.ReadLine();
            }
            
        }
    }
}

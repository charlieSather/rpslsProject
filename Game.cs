using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        string gameMode;
        readonly int numRounds = 3;

        public void BeginMatch()
        {
            DisplayRules();
            SetGameMode();
            SetPlayers();
            PlayRounds();
            DisplayWinner();
            PromptPlayAgain();
        }
        public void SetPlayers()
        {
            switch (gameMode)
            {
                case ("Single Player"):
                    playerOne = new Human();
                    playerOne.SetName();
                    playerTwo = new Computer();
                    break;
                case ("Multiplayer"):
                    playerOne = new Human();
                    playerOne.SetName();
                    playerTwo = new Human();
                    playerTwo.SetName();
                    break;
                default:
                    SetGameMode();
                    break;
            }
        }
        public void SetGameMode()
        {
            Console.WriteLine("Please select game mode");
            Console.WriteLine("1: Single Player\n2: Multiplayer");

            switch (Console.ReadLine())
            {
                case ("1"):
                    gameMode = "Single Player";
                    Console.WriteLine("\nSingle Player selected!");
                    break;
                case ("2"):
                    gameMode = "Multiplayer";
                    Console.WriteLine("\nMultiplayer selected!");
                    break;
                default:
                    SetGameMode();
                    break;
            }
        }
       
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!!!\n");
            Console.WriteLine("Players may play against a computer or another player in a best of three match");
            Console.WriteLine("Players will choose a Gesture and compare their gesture to their opponent's");
            Console.WriteLine("Outcomes are defined as follows:");
            List<string> outcomes = new List<string>
            {
                "Rock crushes Scissors",
                "Scissors cuts Paper",
                "Paper covers Rock",
                "Rock crushes Lizard",
                "Lizard poisons Spock",
                "Spock smashes Scissors",
                "Scissors decapitates Lizard",
                "Lizard eats Paper",
                "Paper disproves Spock",
                "Spock vaporizes Rock",
            };
            foreach(string outcome in outcomes)
            {
                Console.WriteLine(outcome);
            }
            Console.WriteLine();
        }

        public void DisplayWinner()
        {
            if(playerOne.score > playerTwo.score)
            {
                Console.WriteLine($"{playerOne.name} wins!!!\n");
            }
            else
            {
                Console.WriteLine($"{playerTwo.name} wins!!!\n");
            }
        }

        public void PlayRounds()
        {
            int roundResult = 0;

            for(int i = 0; i < numRounds; i++)
            {
                while (roundResult == 0)
                {
                    playerOne.ChooseGesture();
                    playerTwo.ChooseGesture();

                    Console.WriteLine($"{playerOne.name}'s {playerOne.move.name} vs. {playerTwo.name}'s {playerTwo.move.name}");
                    
                    roundResult = playerOne.move.Matchup(playerTwo.move);
                    if(roundResult == 1)
                    {
                        playerOne.score++;
                        Console.WriteLine($"{playerOne.name} wins round {i + 1} and has a score of {playerOne.score}");
                    }
                    else if (roundResult == 2)
                    {
                        playerTwo.score++;
                        Console.WriteLine($"{playerTwo.name} wins round {i + 1} and has a score of {playerTwo.score}");

                    }
                }
                roundResult = 0;
                if(playerOne.score > 1 || playerTwo.score > 1)
                {
                    break;
                }
            }                   
        }
       
        public void PromptPlayAgain()
        {
            Console.WriteLine("\nPlay Again? (yes or no)");
            bool validInput = false;

            while (validInput == false)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "yes")
                {
                    Console.Clear();
                    BeginMatch();
                    validInput = true;
                }
                else if (input.ToLower() == "no")
                {
                    Console.WriteLine("\nThis program will self destruct in...");
                    Thread.Sleep(1000);
                    for(int i = 3; i > 0; i--)
                    {
                        Console.WriteLine(i);
                        Thread.Sleep(1000);
                    }
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("\nInvalid command please enter again");
                }
            }
        }
    }
}

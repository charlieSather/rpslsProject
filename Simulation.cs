using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    class Simulation
    {
        Player playerOne;
        Player playerTwo;
        string gameMode;

        public void Run()
        {            
            SetupPlayers();

            Match match = new Match(playerOne, playerTwo, gameMode);
            match.BeginMatch();

          //  Console.WriteLine($"{playerOne.name}'s {playerOne.move.name} vs. {playerTwo.name}'s {playerTwo.move.name}");
         //   playerOne.move.Matchup(playerTwo.move);




            Console.ReadLine();
        }

        public void SetupPlayers()
        {
            Console.WriteLine("Please select game mode");
            Console.WriteLine("1: Single Player\n2: Multiplayer");

            bool validInput = false;
            string input;
            string playerName;

            while(validInput == false)
            {
                input = Console.ReadLine();
                if(input == "1")
                {
                    Console.WriteLine("\nSingle Player it is!\nPlayer one please enter your name");
                    playerName = PromptPlayerName();
                    playerOne = new Human(playerName);
                    playerTwo = new Computer();
                    gameMode = "Single Player";

                    validInput = true;
                }
                else if(input == "2")
                {
                    Console.WriteLine("\nMultiplayer it is!\nPlayer one please enter your name");
                    playerName = PromptPlayerName(); 
                    playerOne = new Human(playerName);

                    Console.WriteLine("\nPlayer two please enter your name");
                    playerName = PromptPlayerName();
                    playerTwo = new Human(playerName);

                    gameMode = "Multiplayer";
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("\ninvalid selection please try again");
                }
            }
        }

        public string PromptPlayerName()
        {
            string input = "";
            while(input == "")
            {
                input = Console.ReadLine();
                if(input == "")
                {
                    Console.WriteLine("Please enter a name");
                }
            }
            return input;
        }
    }
}

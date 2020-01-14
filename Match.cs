using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    class Match
    {
        Player playerOne;
        Player playerTwo;
        string gameMode;

        public Match(Player playerOne, Player playerTwo, string gameMode)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            this.gameMode = gameMode;
        }

        public Match()
        {

        }

        public void BeginMatch()
        {
            //Round2();
            Round();
        }

        public void DisplayWinner()
        {
            if(playerOne.wins > playerTwo.wins)
            {
                Console.WriteLine($"{playerOne.name} wins with {playerOne.wins}");
            }
            else
            {
                Console.WriteLine($"{playerTwo.name} wins with {playerTwo.wins}");
            }
        }

        public void Round()
        {
            int roundResult = 0;
            int numRounds = 3;

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
                        playerOne.WinRound();
                    }
                    else if (roundResult == 2)
                    {
                        playerTwo.WinRound();
                    }


                }
                roundResult = 0;
            }

            DisplayWinner();                           
        }
        public void Round2()
        {
            int numRounds = 3;
            bool successfulRound = false;

            for (int i = 0; i < numRounds; i++)
            {

                while (successfulRound == false)
                {
                    playerOne.ChooseGesture();
                    playerTwo.ChooseGesture();

                    Console.WriteLine($"{playerOne.name}'s {playerOne.move.name} vs. {playerTwo.name}'s {playerTwo.move.name}");

                    successfulRound = playerOne.move.Matchup(playerOne, playerTwo);
                }

                successfulRound = false;
            }

            DisplayWinner();
        }
    }
}

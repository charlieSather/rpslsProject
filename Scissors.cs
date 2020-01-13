﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    class Scissors : Gesture
    {
        public Scissors()
        {
            name = "Scissors";
        }
        public override bool Matchup(Player playerOne, Player playerTwo)
        {
            bool successfulRound = false;

            switch (playerTwo.move.name)
            {
                case ("Paper"):
                    Console.WriteLine($"{name} cuts {playerTwo.move.name}!!!");
                    playerOne.WinRound();
                    successfulRound = true;
                    break;
                case ("Lizard"):
                    Console.WriteLine($"{name} decapitates {playerTwo.move.name}!!!");
                    playerOne.WinRound();
                    successfulRound = true;
                    break;
                case ("Rock"):
                    Console.WriteLine($"{playerTwo.move.name} crushes {name}!!!");
                    playerTwo.WinRound();
                    successfulRound = true;
                    break;
                case ("Spock"):
                    Console.WriteLine($"{playerTwo.move.name} smashes {name}!!!");
                    playerTwo.WinRound();
                    successfulRound = true;
                    break;
                default:
                    Console.WriteLine("No one wins, pick again");
                    break;
            }

            return successfulRound;
        }
    }
}

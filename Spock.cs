using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    class Spock : Gesture
    {
        public Spock()
        {
            name = "Spock";
        }
        public override bool Matchup(Player playerOne, Player playerTwo)
        {
            bool successfulRound = false;

            switch (playerTwo.move.name)
            {
                case ("Scissors"):
                    Console.WriteLine($"{name} smashes {playerTwo.move.name}!!!");
                    playerOne.WinRound();
                    successfulRound = true;
                    break;
                case ("Rock"):
                    Console.WriteLine($"{name} vaporizes {playerTwo.move.name}!!!");
                    playerOne.WinRound();
                    successfulRound = true;
                    break;
                case ("Lizard"):
                    Console.WriteLine($"{playerTwo.move.name} poisons {name}!!!");
                    playerTwo.WinRound();
                    successfulRound = true;
                    break;
                case ("Paper"):
                    Console.WriteLine($"{playerTwo.move.name} disproves {name}!!!");
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

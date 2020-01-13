using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    class Paper : Gesture
    {

        public Paper()
        {
            name = "Paper";
        }

        public override bool Matchup(Player playerOne,Player playerTwo)
        {
            bool successfulRound = false;

            switch (playerTwo.move.name)
            {
                case ("Rock"):
                    Console.WriteLine($"{name} covers {playerTwo.move.name}!!!");
                    playerOne.WinRound();
                    successfulRound = true;
                    break;
                case ("Spock"):
                    Console.WriteLine($"{name} disproves {playerTwo.move.name}!!!");
                    playerOne.WinRound();
                    successfulRound = true;
                    break;
                case ("Scissors"):
                    Console.WriteLine($"{playerTwo.move.name} cuts {name}!!!");
                    playerTwo.WinRound();
                    successfulRound = true;
                    break;
                case ("Lizard"):
                    Console.WriteLine($"{playerTwo.move.name} eats {name}!!!");
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

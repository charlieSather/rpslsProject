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
                    playerOne.score++;
                    successfulRound = true;
                    break;
                case ("Spock"):
                    Console.WriteLine($"{name} disproves {playerTwo.move.name}!!!");
                    playerOne.score++;
                    successfulRound = true;
                    break;
                case ("Scissors"):
                    Console.WriteLine($"{playerTwo.move.name} cuts {name}!!!");
                    playerTwo.score++;
                    successfulRound = true;
                    break;
                case ("Lizard"):
                    Console.WriteLine($"{playerTwo.move.name} eats {name}!!!");
                    playerTwo.score++;
                    successfulRound = true;
                    break;
                default:
                    Console.WriteLine("No one wins, pick again");
                    break;
            }

            return successfulRound;
        }
        public override int Matchup(Gesture gesture)
        {
            int roundResult = 0;

            switch (gesture.name)
            {
                case ("Rock"):
                    Console.WriteLine($"{name} covers {gesture.name}!!!");
                    roundResult = 1;
                    break;
                case ("Spock"):
                    Console.WriteLine($"{name} disproves {gesture.name}!!!");
                    roundResult = 1;
                    break;
                case ("Scissors"):
                    Console.WriteLine($"{gesture.name} cuts {name}!!!");
                    roundResult = 2;
                    break;
                case ("Lizard"):
                    Console.WriteLine($"{gesture.name} eats {name}!!!");
                    roundResult = 2;
                    break;
                default:
                    Console.WriteLine("No one wins, pick again");
                    break;
            }

            return roundResult;
        }
    }
}

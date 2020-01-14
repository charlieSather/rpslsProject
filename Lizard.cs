using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    class Lizard : Gesture
    {

        public Lizard()
        {
            name = "Lizard";
        }

        public override bool Matchup(Player playerOne, Player playerTwo)
        {
            bool successfulRound = false;

            switch (playerTwo.move.name)
            {
                case ("Spock"):
                    Console.WriteLine($"{name} poisons {playerTwo.move.name}!!!");
                    playerOne.score++;
                    successfulRound = true;
                    break;
                case ("Paper"):
                    Console.WriteLine($"{name} eats {playerTwo.move.name}!!!");
                    playerOne.score++;
                    successfulRound = true;
                    break;
                case ("Rock"):
                    Console.WriteLine($"{playerTwo.move.name} crushes {name}!!!");
                    playerTwo.score++;
                    successfulRound = true;
                    break;
                case ("Scissors"):
                    Console.WriteLine($"{playerTwo.move.name} decapitates {name}!!!");
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
                case ("Spock"):
                    Console.WriteLine($"{name} poisons {gesture.name}!!!");
                    roundResult = 1;
                    break;
                case ("Paper"):
                    Console.WriteLine($"{name} eats {gesture.name}!!!");
                    roundResult = 1;
                    break;
                case ("Rock"):
                    Console.WriteLine($"{gesture.name} crushes {name}!!!");
                    roundResult = 2;
                    break;
                case ("Scissors"):
                    Console.WriteLine($"{gesture.name} decapitates {name}!!!");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    class Rock : Gesture
    {
        public Rock()
        {
            name = "Rock";
        }

        public override bool Matchup(Player playerOne, Player playerTwo)
        {
            bool successfulRound = false;

            switch (playerTwo.move.name)
            {
                case ("Scissors"):
                    Console.WriteLine($"{name} crushes {playerTwo.move.name}!!!");
                    playerOne.WinRound();
                    successfulRound = true;
                    break;
                case ("Lizard"):
                    Console.WriteLine($"{name} crushes {playerTwo.move.name}!!!");
                    playerOne.WinRound();
                    successfulRound = true;
                    break;
                case ("Paper"):
                    Console.WriteLine($"{playerTwo.move.name} covers {name}!!!");
                    playerTwo.WinRound();
                    successfulRound = true;
                    break;
                case ("Spock"):
                    Console.WriteLine($"{playerTwo.move.name} vaporizes {name}!!!");
                    playerTwo.WinRound();
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
                case ("Scissors"):
                    Console.WriteLine($"{name} crushes {gesture.name}!!!");
                    roundResult = 1;
                    break;
                case ("Lizard"):
                    Console.WriteLine($"{name} crushes {gesture.name}!!!");
                    roundResult = 1;
                    break;
                case ("Paper"):
                    Console.WriteLine($"{gesture.name} covers {name}!!!");
                    roundResult = 2;
                    break;
                case ("Spock"):
                    Console.WriteLine($"{gesture.name} vaporizes {name}!!!");
                    roundResult = 2;
                    break;
                default:
                    Console.WriteLine("No one wins, pick again");
                    break;
            }
            return roundResult;
        }

        /*
        public override void Matchup(Gesture gesture)
        {
            switch (gesture.name)
            {
                case ("Scissors"):
                    Console.WriteLine($"{name} crushes {gesture.name}!!!");
                    break;
                case ("Lizard"):
                    Console.WriteLine($"{name} crushes {gesture.name}!!!");                    
                    break;
                case ("Paper"):
                    Console.WriteLine($"{gesture.name} covers {name}!!!");
                    break;
                case ("Spock"):
                    Console.WriteLine($"{gesture.name} vaporizes {name}!!!");                    
                    break;
                default:
                    Console.WriteLine("No one wins, pick again");
                    break;
            }
        }
        */


    }
}

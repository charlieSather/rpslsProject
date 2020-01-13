using System;
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
        public override void Matchup(Gesture gesture)
        {
            switch (gesture.name)
            {
                case ("Paper"):
                    Console.WriteLine($"{name} cuts {gesture.name}!!!");
                    break;
                case ("Lizard"):
                    Console.WriteLine($"{name} decapitates {gesture.name}!!!");
                    break;
                case ("Rock"):
                    Console.WriteLine($"{gesture.name} crushes {name}!!!");
                    break;
                case ("Spock"):
                    Console.WriteLine($"{gesture.name} smashes {name}!!!");
                    break;
                default:
                    Console.WriteLine("No one wins, pick again");
                    break;
            }
        }
    }
}

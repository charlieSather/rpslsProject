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

        public override void Matchup(Gesture gesture)
        {
            switch (gesture.name)
            {
                case ("Spock"):
                    Console.WriteLine($"{name} poisons {gesture.name}!!!");
                    break;
                case ("Paper"):
                    Console.WriteLine($"{name} eats {gesture.name}!!!");
                    break;
                case ("Rock"):
                    Console.WriteLine($"{gesture.name} crushes {name}!!!");
                    break;
                case ("Scissors"):
                    Console.WriteLine($"{gesture.name} decapitates {name}!!!");
                    break;
                default:
                    Console.WriteLine("No one wins, pick again");
                    break;
            }
        }

    }
}

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
        public override void Matchup(Gesture gesture)
        {
            switch (gesture.name)
            {
                case ("Scissors"):
                    Console.WriteLine($"{name} smashes {gesture.name}!!!");
                    break;
                case ("Rock"):
                    Console.WriteLine($"{name} vaporizes {gesture.name}!!!");
                    break;
                case ("Lizard"):
                    Console.WriteLine($"{gesture.name} poisons {name}!!!");
                    break;
                case ("Paper"):
                    Console.WriteLine($"{gesture.name} disproves {name}!!!");
                    break;
                default:
                    Console.WriteLine("No one wins, pick again");
                    break;
            }

        }
    }
}

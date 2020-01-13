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

    }
}

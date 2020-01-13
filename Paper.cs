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

        public override void Matchup(Gesture gesture)
        {
            switch (gesture.name)
            {
                case ("Rock"):
                    Console.WriteLine($"{name} covers {gesture.name}!!!");
                    break;
                case ("Spock"):
                    Console.WriteLine($"{name} disproves {gesture.name}!!!");
                    break;
                case ("Scissors"):
                    Console.WriteLine($"{gesture.name} cuts {name}!!!");
                    break;
                case ("Lizard"):
                    Console.WriteLine($"{gesture.name} eats {name}!!!");
                    break;
                default:
                    Console.WriteLine("No one wins, pick again");
                    break;
            }
        }
    }
}

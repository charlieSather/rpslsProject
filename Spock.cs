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
     
        public override int Matchup(Gesture gesture)
        {
            int roundResult = 0;

            switch (gesture.name)
            {
                case ("Scissors"):
                    Console.WriteLine($"{name} smashes {gesture.name}!!!");
                    roundResult = 1;
                    break;
                case ("Rock"):
                    Console.WriteLine($"{name} vaporizes {gesture.name}!!!");
                    roundResult = 1;
                    break;
                case ("Lizard"):
                    Console.WriteLine($"{gesture.name} poisons {name}!!!");
                    roundResult = 2;
                    break;
                case ("Paper"):
                    Console.WriteLine($"{gesture.name} disproves {name}!!!");
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

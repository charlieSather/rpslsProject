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

    }
}

﻿using System;
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

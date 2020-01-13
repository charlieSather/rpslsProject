using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    class Human : Player
    {
        public Human(string name)
        {
            this.name = name;
            move = null;
        }

        public override void ChooseGesture()
        {
            Console.WriteLine($"\nPlease select a move {name}");
            Console.WriteLine($"\nPlease select a move {name}");

            bool validInput = false;
            string input;
            Gesture move = null;

            while(validInput == false)
            {
                PrintMoves();
                input = Console.ReadLine();       
                
                foreach(Gesture gesture in moves)
                {
                    if(input.ToLower() == gesture.name.ToLower())
                    {
                        move = gesture;
                        validInput = true;
                        break;
                    }
                }
                if(validInput == false)
                {
                    Console.WriteLine("Sorry we could not find your move. Please try again.");
                }
            }
            this.move = move;
            Console.WriteLine();
        }
    }
}

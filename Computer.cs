using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    class Computer : Player
    {
        Random rand;

        public Computer()
        {
            name = "Computer";
            rand = new Random();
            move = null;
        }
        public override void ChooseGesture()
        {
            move = moves[rand.Next(0, moves.Count)];
            Console.WriteLine($"{name} selects {move.name}!\n");
        }
        public override void SetName() { }
    }
}

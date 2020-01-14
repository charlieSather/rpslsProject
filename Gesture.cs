using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    abstract class Gesture
    {
        public string name { get; set; }

        public Gesture()
        {

        }

        public abstract bool Matchup(Player playerOne, Player playerTwo);
        public abstract int Matchup(Gesture gesture);


    }
}

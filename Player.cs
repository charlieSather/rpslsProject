using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    abstract class Player
    {
        public int score { get; set; }
        public Gesture move { get; set; }
        public List<Gesture> moves { get; private set; }

        public string name { get; set; }

        public Player()
        {
            moves = new List<Gesture>
            {
                new Rock(),
                new Paper(),
                new Scissors(),
                new Lizard(),
                new Spock()
            };
        }

        public abstract void ChooseGesture();
        public abstract void SetName();


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    class Lizard : Gesture
    {

        public Lizard()
        {
            name = "Lizard";
        }


        public override string ToString()
        {
            return name;
        }
    }
}

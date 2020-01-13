using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    class Simulation
    {
        public void Run()
        {
            Human human = new Human("Carl");
            Computer computer = new Computer();
          //  human.PrintMoves();

            human.ChooseGesture();
            computer.ChooseGesture();



            Console.WriteLine($"{computer.name}'s {computer.move.name} vs. {human.name}'s {human.move.name}");

            human.move.Matchup(computer.move);


            Console.ReadLine();
        }
    }
}

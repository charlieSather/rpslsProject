using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    class Human : Player
    {
        public Human()
        {
            move = null;
        }

        public override void ChooseGesture()
        {
            Console.WriteLine($"\nPlease select a move {name}");
            PrintMoves();
            string input = Console.ReadLine();

            switch (input)
            {
                case ("1"):
                    move = moves[int.Parse(input) - 1];
                    break;
                case ("2"):
                    move = moves[int.Parse(input) - 1];
                    break;
                case ("3"):
                    move = moves[int.Parse(input) - 1];
                    break;
                case ("4"):
                    move = moves[int.Parse(input) - 1];
                    break;
                case ("5"):
                    move = moves[int.Parse(input) - 1];
                    break;
                default:
                    Console.WriteLine("\nThat's not a move!!!\nTry Again.");
                    ChooseGesture();
                    break;
            }
            Console.WriteLine($"{move.name} Selected!\n");

        }

        public override void SetName()
        {
            string input = "";
            Console.WriteLine("\nPlease enter a name for player");
            while (input == "")
            {
                input = Console.ReadLine();
                if (input == "")
                {
                    Console.WriteLine("Please enter a name");
                }
            }
            name = input;
            Console.WriteLine($"Thanks {name}");
        }

        public void PrintMoves()
        {
            int num = 1;
            for (int i = 0; i < moves.Count; i++)
            {
                Console.WriteLine($"{num}: {moves[i].name}");
                num++;
            }
        }

    }
}

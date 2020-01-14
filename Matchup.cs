using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    class Matchup
    {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        public bool DetermineWinner(Player playerOne, Player playerTwo)
        {
            bool hasOutcome = false;

            if (map[playerOne.move.name].Contains(playerTwo.move.name))
            {
                //findIndex() returns -1 if it somehow can't find the index of playerTwo's gesture in the key's list
                int index = map[playerOne.move.name].FindIndex(gesture => gesture == playerTwo.move.name);
                if (index > -1 && index < 2)
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round and has a score of {playerOne.score}");
                    hasOutcome = true;
                }
                else if(index > 1)
                {
                    playerTwo.score++;
                    Console.WriteLine($"{playerTwo.name} wins the round and has a score of {playerTwo.score}");
                    hasOutcome = true;
                }
                
            }

            return hasOutcome;
        }

        //Each key in dictionary is a gesture string and has its own list of ordered gestures.
        //First two items in each key's list are gestures they win against, last two are ones they lose to.
        public void init()
        {
            map.Add("Rock", new List<string> { "Scissors", "Lizard", "Paper", "Spock" });
            map.Add("Paper", new List<string> { "Rock", "Spock", "Scissors", "Lizard" });
            map.Add("Scissors", new List<string> { "Paper", "Lizard", "Rock", "Spock" });
            map.Add("Lizard", new List<string> { "Spock", "Paper", "Rock", "Scissors" });
            map.Add("Spock", new List<string> { "Rock", "Scissors", "Lizard", "Paper" });
        }





    }
}

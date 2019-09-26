using System;
using System.Collections.Generic;
using System.Threading;

namespace RockPaperScissors
{
    public class Lizard : Gesture
    {




        public Lizard()
        {
            name = "lizard";
            defeats = new List<string>() { "paper", "spock" };
        }


        public override void FindVerb(string enemy)
        {

            if (enemy == defeats[0])
            {
                verb = "eats";
            }
            else if (enemy == defeats[1])
            {
                verb = "poisons";
            }
        }




    }
}

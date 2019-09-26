using System;
using System.Collections.Generic;
using System.Threading;

namespace RockPaperScissors
{
    public class Scissors : Gesture
    {






        public Scissors()
        {
            name = "scissors";
            defeats = new List<string>() { "paper", "lizard" };
        }


        public override void FindVerb(string enemy)
        {

            if (enemy == defeats[0])
            {
                verb = "cuts";
            }
            else if (enemy == defeats[1])
            {
                verb = "decapitates";
            }
        }



    }
}

using System;
using System.Collections.Generic;
using System.Threading;

namespace RockPaperScissors
{
    public class Rock : Gesture
    {






        public Rock()
        {
            name = "rock";
            defeats = new List<string>() { "scissors", "lizard" };
        }


        public override void FindVerb(string enemy)
        {

            if (enemy == defeats[0])
            {
                verb = "smashes";
            }
            else if (enemy == defeats[1])
            {
                verb = "crushes";
            }
        }

      



    }
}

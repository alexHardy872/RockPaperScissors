using System;
using System.Collections.Generic;
using System.Threading;

namespace RockPaperScissors
{
    public class Paper : Gesture
    {




        public Paper()
        {
            name = "paper";
            defeats = new List<string>() { "rock", "spoc" };
        }


        public override void FindVerb(string enemy)
        {

            if (enemy == defeats[0])
            {
                verb = "covers";
            }
            else if (enemy == defeats[1])
            {
                verb = "disproves";
            }
        }



    }
}

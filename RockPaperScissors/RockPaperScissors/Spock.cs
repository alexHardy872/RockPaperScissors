using System;
using System.Collections.Generic;
using System.Threading;

namespace RockPaperScissors
{
    public class Spock : Gesture
    {






        public Spock()
        {
            name = "spock";
            defeats = new List<string>() { "scissors", "rock" };
        }


        public override void FindVerb(string enemy)
        {

            if (enemy == defeats[0])
            {
                verb = "smashes";
            }
            else if (enemy == defeats[1])
            {
                verb = "vaporizes";
            }
        }






    }
}

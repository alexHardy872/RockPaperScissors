using System;
using System.Collections.Generic;
using System.Threading;

namespace RockPaperScissors
{
    public abstract class Gesture
    {
        public string name;
        public string verb;
        public List<string> defeats;


        public Gesture()
        {
        }



        public abstract void FindVerb(string enemy);

        

    }
}

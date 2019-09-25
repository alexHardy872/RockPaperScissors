using System;
using System.Collections.Generic;
using System.Threading;

namespace RockPaperScissors
{
    public class Comp : Player
    {
        public int randomNum;

        public Comp()
        {
        }


        public override void SelectHandState()
        {
            // RANDOMNUMBER
            // INTERPREY FROM LIST
            int random = getRandomNum();
            string selection = HandStates[random];
            this.HandState = selection;
        }

        public int getRandomNum()
        {
            Random random = new Random();
            int selection = random.Next(0, 4);
            return selection;
        }
    }
}

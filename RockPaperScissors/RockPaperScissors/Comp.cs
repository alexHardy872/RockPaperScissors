using System;
using System.Collections.Generic;
using System.Threading;

namespace RockPaperScissors
{
    public class Comp : Player
    {
        public int randomNum;
        public Comp(string nameIn)
        {
            name = nameIn;
        }


        public override void SelectHandState()
        {
            // RANDOMNUMBER
            // INTERPREY FROM LIST
            int random = GetRandomNum();
            string selection = HandStates[random];
            this.HandState = selection;
            SetGesture(selection);
        }

        public int GetRandomNum()
        {
            Random random = new Random();
            int selection = random.Next(0, 4);
            return selection;
        }
    }
}

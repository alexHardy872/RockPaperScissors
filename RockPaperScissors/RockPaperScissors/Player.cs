using System;
using System.Collections.Generic;
using System.Threading;


namespace RockPaperScissors
{
    public abstract class Player
    {

        public List<string> HandStates = new List<string>() {"Rock", "Paper", "Scissors", "Lizard", "Spoc"};
        string HandState;



        public Player()
        {
        }




        public void Shoot()
        {

        }

        public abstract void SelectHandState();
        
    }
}

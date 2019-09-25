using System;
using System.Collections.Generic;
using System.Threading;


namespace RockPaperScissors
{
    public abstract class Player
    {

        public List<string> HandStates;
        public string HandState;
        public string name;
        public int score;



         public Player()
        {
            score = 0;
            HandStates = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        }




        public void Shoot()
        {

        }

        public abstract void SelectHandState();
        
    }
}

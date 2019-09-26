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
        public Gesture gesture;



         public Player()
        {
            score = 0;
            HandStates = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        }




        public void Shoot()
        {
            
        }

        public abstract void SelectHandState();

        public void SetGesture(string choice)
        {

            switch (choice)
            {

                case "rock":
                    gesture = new Rock();
                    break;
                case "paper":
                    gesture = new Paper();
                    break;
                case "scissors":
                    gesture = new Scissors();
                    break;
                case "lizard":
                    gesture = new Lizard();
                    break;
                case "spock":
                    gesture = new Spock();
                    break;

            }
         
        }
        
    }
}

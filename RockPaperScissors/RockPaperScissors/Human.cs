using System;
using System.Collections.Generic;
using System.Threading;

namespace RockPaperScissors
{
    public class Human : Player
    {



        public Human(string nameIn)
        {
            name = nameIn;
        }



        public override void SelectHandState()
        {
            // SELECTOR

            Console.WriteLine( this.name+ "... Please type '"+HandStates[0]+ "' , '" + HandStates[1] + "' , '" + HandStates[2] + "' , '" + HandStates[3] + "' , '" + HandStates[4] + "'");
            string choice = Console.ReadLine();


            if (HandStates.Contains(choice.ToLower()) == true)
            {
                this.HandState = choice;
            }
            else
            {
                Console.WriteLine(choice + " is NOT a valid move!");
                SelectHandState();
            }
            

        }


    }
}

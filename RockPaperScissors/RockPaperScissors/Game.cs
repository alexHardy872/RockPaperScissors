using System;
using System.Collections.Generic;
using System.Threading;

namespace RockPaperScissors
{
    public class Game
    {

        Human playerOne;
        Human playerTwo;
        Comp computer;
        string GameStyle;
        int Round;
        string RoundOne;
        string RoundTwo;
        string RoundThree;


        public Game()
        {

        Round = 1;

        }



        public void DisplayInstructions()
        {
            Console.WriteLine("Welcome to RockPaperScissorsLizardSpoc!");
            ChooseGameStyle();
        }

        public void ChooseGameStyle()
        {
            Console.WriteLine("Play game against the Computer ('comp') or another human ('human')");
            string answer = Console.ReadLine();

            if (answer == "human" || answer == "comp")
            {
                GameStyle = answer;
            }
            else
            {
                Console.WriteLine(answer + " is NOT a valid input!");
                ChooseGameStyle();
            }

            StartGame();

        }

        public void StartGame()
        {
            playerOne = new Human( "PlayerOne");
            playerOne.SelectHandState();

            computer = new Comp();
            computer.SelectHandState();

            PlayRound();
        }


        public void PlayRound()
        {
            Console.WriteLine("3");
            Thread.Sleep(500);
            Console.WriteLine("2");
            Thread.Sleep(500);
            Console.WriteLine("1");
            Thread.Sleep(500);
            Console.WriteLine("Shoot!");
            Thread.Sleep(500);

            Console.WriteLine(" Player one chose " + playerOne.HandState + " the Computer chose " + computer.HandState);




            
        }
    }
}

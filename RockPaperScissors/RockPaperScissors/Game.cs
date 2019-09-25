using System;
using System.Collections.Generic;
using System.Threading;

namespace RockPaperScissors
{
    public class Game
    {

        Human playerOne;
        Human playerTwo;
        Player opponent;
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
            Console.WriteLine("Welcome to RockPaperScissorsLizardSpock!");
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
            playerOne = new Human( "Player 1");
            playerOne.SelectHandState();

            if (GameStyle == "comp")
            {
                opponent = new Comp("Computer");
            }
            else if (GameStyle == "human")
            {
                opponent = new Human("Player 2");
            }

            opponent.SelectHandState();

            PlayRound();
        }


        public void PlayRound()
        {
            Console.Clear();
            Console.WriteLine("3");
            Thread.Sleep(500);
            Console.WriteLine("2");
            Thread.Sleep(500);
            Console.WriteLine("1");
            Thread.Sleep(500);
            Console.WriteLine("Shoot!");
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine(" Player one chose " + playerOne.HandState + " and "+opponent.name+" chose " + opponent.HandState);




            
        }



        public void DeterminWinner()
        {
            //YOU CHOSE ROCK, COMP CHOSE PAPER OR SPOCK

            // YOU CHOSE SCISSORS, COMP SHOCE ROCK OR SPOCK

            // YOU CHOSE PAPER< COMP CHOSE LIZARD OR SCISSORS

            // YOU CHOSE LIZARD, COMP CHOSE ROCK OR SCISSORS

            // YOU CHOSE SPOCK, COMP CHOSE LIZARD OR PAPER


            // ROCK SMASHES SCISSIORS
            // ROCK SMASHES LIZARD
            // PAPER COVERS ROCK
            // PAPER DEASSIGNS SPOCK
            // SCISSORS CUTS PAPER
            //SCISSORS CUTS LIZARD
            // LIZARD POISENDS SPOCK
            // LIZARD EATS PAPER
            // SPOCK SMASHES SCISSORS
            // SPOCK VAPORIZES ROCK

          
        }
    }
}

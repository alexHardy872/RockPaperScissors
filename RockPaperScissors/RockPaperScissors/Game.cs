using System;
using System.Collections.Generic;
using System.Threading;

namespace RockPaperScissors
{
    public class Game
    {

        public Human playerOne;
        public Player opponent;
        string GameStyle;
        int Round;
        
       


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
           

            if (GameStyle == "comp")
            {
                opponent = new Comp("Computer");
            }
            else if (GameStyle == "human")
            {
                opponent = new Human("Player 2");
            }


            

            PlayRound();
        }


        public void PlayRound()
        {
            Console.Clear();
            Console.WriteLine("Round " + Round + "!");
            Thread.Sleep(500);
            Console.Clear();
            playerOne.SelectHandState();
            Console.Clear();
            opponent.SelectHandState();
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

            DeterminWinner();


            
        }



        public void DeterminWinner()
        {
            string us = playerOne.HandState;
            string op = opponent.HandState;



            if (us == op)
            {
                Console.Write("It's a tie! Shoot again!");
                PlayRound();
            }
            else
            {
                if (us == "rock")
                {
                    switch (op)
                    {
                        case "paper": // LOSE
                            opponent.score += 1;
                            Console.WriteLine("Paper covers Rock!");
                            Thread.Sleep(1000);
                            Console.WriteLine(opponent.name+" won the round!");
                            Thread.Sleep(1000);
                            break;
                        case "scissors":
                            playerOne.score += 1;
                            Console.WriteLine("Rock Smashes Scissors!");
                            Thread.Sleep(1000);
                            Console.WriteLine(playerOne.name+" won the round!");
                            Thread.Sleep(1000);
                            break;
                        case "lizard":
                            playerOne.score += 1;
                            Console.WriteLine("Rock smashes Lizard!");
                            Thread.Sleep(1000);
                            Console.WriteLine(playerOne.name + " won the round!");
                            Thread.Sleep(1000);
                            break;
                        case "spock": //LOSE
                            opponent.score += 1;
                            Console.WriteLine("Spock vaporizes Rock!");
                            Thread.Sleep(1000);
                            Console.WriteLine(opponent.name + " won the round!");
                            Thread.Sleep(1000);
                            break;
                    }
                }
                else if (us == "paper")
                {
                    switch (op)
                    {
                        case "rock":
                            playerOne.score += 1;
                            Console.WriteLine("Paper covers Rock!");
                            Thread.Sleep(1000);
                            Console.WriteLine(playerOne.name + " won the round!");
                            Thread.Sleep(1000);
                            break;
                        case "scissors": //LOSE
                            opponent.score += 1;
                            Console.WriteLine("Scissors cuts Paper!");
                            Thread.Sleep(1000);
                            Console.WriteLine(opponent.name + " won the round!");
                            Thread.Sleep(1000);
                            break;
                        case "lizard": //LOSE
                            opponent.score += 1;
                            Console.WriteLine("Lizard eats Paper!");
                            Thread.Sleep(1000);
                            Console.WriteLine(opponent.name + " won the round!");
                            Thread.Sleep(1000);
                            break;
                        case "spock":
                            playerOne.score += 1;
                            Console.WriteLine("Paper disproves Spock!");
                            Thread.Sleep(1000);
                            Console.WriteLine(playerOne.name + " won the round!");
                            Thread.Sleep(1000);
                            break;
                    }
                }
                else if (us == "scissors")
                {
                    switch (op)
                    {
                        case "rock": //LOSE
                            opponent.score += 1;
                            Console.WriteLine("Rock smashes Scissors!");
                            Thread.Sleep(1000);
                            Console.WriteLine(opponent.name + " won the round!");
                            Thread.Sleep(1000);
                            break;
                        case "paper":
                            playerOne.score += 1;
                            Console.WriteLine("Scissors cuts Paper!");
                            Thread.Sleep(1000);
                            Console.WriteLine(playerOne.name + " won the round!");
                            Thread.Sleep(1000);
                            break;
                        case "lizard":
                            playerOne.score += 1;
                            Console.WriteLine("Scissors cut Lizard!");
                            Thread.Sleep(1000);
                            Console.WriteLine(playerOne.name + " won the round!");
                            Thread.Sleep(1000);
                            break;
                        case "spock": //LOSE
                            opponent.score += 1;
                            Console.WriteLine("Spock smashes Scissors!");
                            Thread.Sleep(1000);
                            Console.WriteLine(opponent.name + " won the round!");
                            Thread.Sleep(1000);
                            break;
                    }
                }
                else if (us == "lizard")
                {
                    switch (op)
                    {
                        case "rock": //LOSE
                            opponent.score += 1;
                            Console.WriteLine("Rock smashes Lizard!");
                            Thread.Sleep(1000);
                            Console.WriteLine(opponent.name + " won the round!");
                            Thread.Sleep(1000);
                            break;
                        case "scissors": //LOSE
                            opponent.score += 1;
                            Console.WriteLine("Scissors cuts Lizard!");
                            Thread.Sleep(1000);
                            Console.WriteLine(opponent.name + " won the round!");
                            Thread.Sleep(1000);
                            break;
                        case "paper":
                            playerOne.score += 1;
                            Console.WriteLine("Lizard eats Paper!");
                            Thread.Sleep(1000);
                            Console.WriteLine(playerOne.name + " won the round!");
                            Thread.Sleep(1000);
                            break;
                        case "spock":
                            playerOne.score += 1;
                            Console.WriteLine("Lizard poisens Spock!");
                            Thread.Sleep(1000);
                            Console.WriteLine(playerOne.name + " won the round!");
                            Thread.Sleep(1000);
                            break;
                    }
                }
                else if (us == "spock")
                {
                    switch (op)
                    {
                        case "rock":
                            playerOne.score += 1;
                            Console.WriteLine("Spock vapoizes Rock!");
                            Thread.Sleep(1000);
                            Console.WriteLine(playerOne.name + " won the round!");
                            Thread.Sleep(1000);
                            break;
                        case "scissors":
                            playerOne.score += 1;
                            Console.WriteLine("Spock smashes scissors!");
                            Thread.Sleep(1000);
                            Console.WriteLine(playerOne.name + " won the round!");
                            Thread.Sleep(1000);
                            break;
                        case "lizard": //LOSE
                            opponent.score += 1;
                            Console.WriteLine("Lizard poisens Spock!");
                            Thread.Sleep(1000);
                            Console.WriteLine(opponent.name + " won the round!");
                            Thread.Sleep(1000);
                            break;
                        case "paper": //LOSE
                            opponent.score += 1;
                            Console.WriteLine("Paper disproves Spock!");
                            Thread.Sleep(1000);
                            Console.WriteLine(opponent.name + " won the round!");
                            Thread.Sleep(1000);
                            break;
                    }
                }

                
            } 


            DetermineRoundWinner();
        }

        public void DetermineRoundWinner()
        {
            if (playerOne.score == 2)
            {
                // P1 WIN
                Console.WriteLine(playerOne.name + " won 2/3 rounds!");
                PlayAgainPrompt();
            }
            else if (opponent.score == 2)
            {
                // P2 WIN
            }
            else
            {
                Round += 1;
                PlayRound();
            }
        }

        public void PlayAgainPrompt()
        {
            Console.Write("Play again? ('yes') ot ('no') ");
            string input = Console.ReadLine();
            if (input.ToLower() == "yes")
            {
                Console.Clear();
                Game nextGame = new Game();
                nextGame.ChooseGameStyle();
            }
            else if (input.ToLower() == "no")
            {
                Console.WriteLine("Thanks for playing!");
                Console.Clear();
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Not a valid response");
                PlayAgainPrompt();
            }
        }
    }
}

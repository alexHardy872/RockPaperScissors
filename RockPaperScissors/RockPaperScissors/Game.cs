using System;
using System.Collections.Generic;
using System.Threading;

namespace RockPaperScissors
{
    public class Game
    {

        public Player playerOne;
        public Player opponent;
        string GameStyle;
        int Round;
        
       


        public Game()
        {
            Round = 1;
        

        }



        public void DisplayInstructions()
        {
            Console.WriteLine("WELCOME TO ROCK-PAPER-SCISSORS-LIZARD-SPOCK!");
            Thread.Sleep(2000);
            Console.WriteLine("");

            Console.WriteLine("HOW TO PLAY:");
            Thread.Sleep(1000);
            Console.WriteLine("");

            Console.WriteLine("SCISSORS CUTS PAPER");
            Thread.Sleep(1000);

            Console.WriteLine("PAPER COVERS ROCK");
            Thread.Sleep(1000);

            Console.WriteLine("ROCK CRUSHES LIZARD");
            Thread.Sleep(1000);

            Console.WriteLine("LIZARD POISENS SPOCK");
            Thread.Sleep(1000);

            Console.WriteLine("SPOCK SMASHES SCISSORS");
            Thread.Sleep(1000);


            Console.WriteLine("SCISSORS DECAPITATES LIZARD");
            Thread.Sleep(1000);


            Console.WriteLine("LIZARD EATS PAPER");
            Thread.Sleep(1000);

            Console.WriteLine("PAPER DISPROVES SPOCK");
            Thread.Sleep(1000);
            Console.WriteLine("");

            Console.Write("AND AS IT ALWAYS HAS.....");
            Thread.Sleep(1200);

            Console.WriteLine("ROCK CRUSHES SCISSORS");
            Thread.Sleep(1000);
            Console.WriteLine("");

            ChooseGameStyle();
        }

        public void ChooseGameStyle()
        {
            Console.WriteLine("Play game against the Computer ('comp') or another human ('human') OR a simulation ('sim')?");
            string answer = Console.ReadLine();

            if (answer == "human" || answer == "comp" || answer == "sim")
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
           
           
            if (GameStyle == "sim")
            {
                playerOne = new Comp("Computer 1");

            } else
            {
                playerOne = new Human("Player 1");
            }



            if (GameStyle == "comp")
            {
                opponent = new Comp("Computer");
            }
            else if (GameStyle == "human")
            {
                opponent = new Human("Player 2");
            }
            else if (GameStyle == "sim")
            {
                opponent = new Comp("Computer 2");
            }


            

            PlayRound();
        }


        public void PlayRound()
        {
            Console.Clear();
            Console.WriteLine("Round " + Round + "!");
            Thread.Sleep(1000);
            Console.Clear();

            playerOne.SelectHandState();
            Console.Clear();

            opponent.SelectHandState();
            Console.Clear();
            Thread.Sleep(500);

            Console.WriteLine("3");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("2");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("1");
            Thread.Sleep(500);
            Console.Clear();
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
                Thread.Sleep(1500);
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
                            Thread.Sleep(1500);
                            Console.WriteLine(opponent.name+" won the round!");
                            Thread.Sleep(1500);
                            break;
                        case "scissors":
                            playerOne.score += 1;
                            Console.WriteLine("Rock crushes Scissors!");
                            Thread.Sleep(1500);
                            Console.WriteLine(playerOne.name+" won the round!");
                            Thread.Sleep(1500);
                            break;
                        case "lizard":
                            playerOne.score += 1;
                            Console.WriteLine("Rock crushes Lizard!");
                            Thread.Sleep(1500);
                            Console.WriteLine(playerOne.name + " won the round!");
                            Thread.Sleep(1500);
                            break;
                        case "spock": //LOSE
                            opponent.score += 1;
                            Console.WriteLine("Spock vaporizes Rock!");
                            Thread.Sleep(1500);
                            Console.WriteLine(opponent.name + " won the round!");
                            Thread.Sleep(1500);
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
                            Thread.Sleep(1500);
                            Console.WriteLine(playerOne.name + " won the round!");
                            Thread.Sleep(1500);
                            break;
                        case "scissors": //LOSE
                            opponent.score += 1;
                            Console.WriteLine("Scissors cuts Paper!");
                            Thread.Sleep(1500);
                            Console.WriteLine(opponent.name + " won the round!");
                            Thread.Sleep(1500);
                            break;
                        case "lizard": //LOSE
                            opponent.score += 1;
                            Console.WriteLine("Lizard eats Paper!");
                            Thread.Sleep(1500);
                            Console.WriteLine(opponent.name + " won the round!");
                            Thread.Sleep(1500);
                            break;
                        case "spock":
                            playerOne.score += 1;
                            Console.WriteLine("Paper disproves Spock!");
                            Thread.Sleep(1500);
                            Console.WriteLine(playerOne.name + " won the round!");
                            Thread.Sleep(1500);
                            break;
                    }
                }
                else if (us == "scissors")
                {
                    switch (op)
                    {
                        case "rock": //LOSE
                            opponent.score += 1;
                            Console.WriteLine("Rock crushes Scissors!");
                            Thread.Sleep(1500);
                            Console.WriteLine(opponent.name + " won the round!");
                            Thread.Sleep(1500);
                            break;
                        case "paper":
                            playerOne.score += 1;
                            Console.WriteLine("Scissors cuts Paper!");
                            Thread.Sleep(1500);
                            Console.WriteLine(playerOne.name + " won the round!");
                            Thread.Sleep(1500);
                            break;
                        case "lizard":
                            playerOne.score += 1;
                            Console.WriteLine("Scissors decapitates Lizard!");
                            Thread.Sleep(1500);
                            Console.WriteLine(playerOne.name + " won the round!");
                            Thread.Sleep(1500);
                            break;
                        case "spock": //LOSE
                            opponent.score += 1;
                            Console.WriteLine("Spock smashes Scissors!");
                            Thread.Sleep(1500);
                            Console.WriteLine(opponent.name + " won the round!");
                            Thread.Sleep(1500);
                            break;
                    }
                }
                else if (us == "lizard")
                {
                    switch (op)
                    {
                        case "rock": //LOSE
                            opponent.score += 1;
                            Console.WriteLine("Rock crushes Lizard!");
                            Thread.Sleep(1500);
                            Console.WriteLine(opponent.name + " won the round!");
                            Thread.Sleep(1500);
                            break;
                        case "scissors": //LOSE
                            opponent.score += 1;
                            Console.WriteLine("Scissors decapitates Lizard!");
                            Thread.Sleep(1500);
                            Console.WriteLine(opponent.name + " won the round!");
                            Thread.Sleep(1500);
                            break;
                        case "paper":
                            playerOne.score += 1;
                            Console.WriteLine("Lizard eats Paper!");
                            Thread.Sleep(1500);
                            Console.WriteLine(playerOne.name + " won the round!");
                            Thread.Sleep(1500);
                            break;
                        case "spock":
                            playerOne.score += 1;
                            Console.WriteLine("Lizard poisens Spock!");
                            Thread.Sleep(1500);
                            Console.WriteLine(playerOne.name + " won the round!");
                            Thread.Sleep(1500);
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
                            Thread.Sleep(1500);
                            Console.WriteLine(playerOne.name + " won the round!");
                            Thread.Sleep(1500);
                            break;
                        case "scissors":
                            playerOne.score += 1;
                            Console.WriteLine("Spock smashes scissors!");
                            Thread.Sleep(1500);
                            Console.WriteLine(playerOne.name + " won the round!");
                            Thread.Sleep(1500);
                            break;
                        case "lizard": //LOSE
                            opponent.score += 1;
                            Console.WriteLine("Lizard poisens Spock!");
                            Thread.Sleep(1500);
                            Console.WriteLine(opponent.name + " won the round!");
                            Thread.Sleep(1500);
                            break;
                        case "paper": //LOSE
                            opponent.score += 1;
                            Console.WriteLine("Paper disproves Spock!");
                            Thread.Sleep(1500);
                            Console.WriteLine(opponent.name + " won the round!");
                            Thread.Sleep(1500);
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

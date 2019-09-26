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
        bool playAgain;
        
       


        public Game()
        {
            Round = 1;
            playAgain = true;
        

        }

        public void StartGame()
        {
            DisplayInstructions();

            do
            {
                RunGame();
            }
            while (playAgain == true);
            
        }

        public void RunGame()
        {
            ChooseGameStyle();
            EstablishPlayers();

            do
            {
                PlayRound();
               bool isTie = DetermineRoundWinner();

                if (isTie == false)
                {
                    Round += 1;

                }

            }
            while (playerOne.score < 2 && opponent.score < 2);



            DetermineWinner();
            PlayAgainPrompt(); 



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
        }


        public void EstablishPlayers()
        {

            switch (GameStyle)
            {
                case "sim":
                    playerOne = new Comp("Computer 1");
                    opponent = new Comp("Computer 2");
                    break;
                case "comp":
                    playerOne = new Human("Player 1");
                    opponent = new Comp("Computer");
                    break;
                case "human":
                    playerOne = new Human("Player 1");
                    opponent = new Human("Player 2");
                    break;
            }
        }



     

        public void PlayRound()
        {
            Console.Clear();
            Console.WriteLine("Round " + Round + "!");
            Thread.Sleep(1000);
            Console.Clear();

            playerOne.SelectHandState();
            Console.Clear();
            Thread.Sleep(500);

            opponent.SelectHandState();
            Console.Clear();
            Thread.Sleep(500);

            Shoot321();

            Console.WriteLine(playerOne.name +" chose " + playerOne.gesture.name + " and "+opponent.name+" chose " + opponent.gesture.name);
            Console.WriteLine();
            Thread.Sleep(2000);
                        
        }



        public bool DetermineRoundWinner() // RETURNS TRUE IF A TIE
        {





            if (playerOne.gesture.name == opponent.gesture.name)
            {
                Console.WriteLine("It's a TIE! replay Round " + Round);
                Thread.Sleep(1000);
                return true;
            }

            else
            {
                if (playerOne.gesture.defeats.Contains(opponent.gesture.name))
                {

                    playerOne.gesture.FindVerb(opponent.gesture.name);
                    Console.WriteLine(playerOne.gesture.name +" "+ playerOne.gesture.verb+ " " + opponent.gesture.name+"!");
                    Thread.Sleep(1000);
                 
                    playerOne.score += 1;
                    Console.WriteLine("Player 1 wins");
                    Thread.Sleep(1000);
                    

                }
                else if (opponent.gesture.defeats.Contains(playerOne.gesture.name))
                {

                    opponent.gesture.FindVerb(playerOne.gesture.name);
                    Console.WriteLine(opponent.gesture.name + " " + opponent.gesture.verb + " " +playerOne.gesture.name+"!" );
                    Thread.Sleep(1000);
                  
                    opponent.score += 1;
                    Console.WriteLine("Player 2 wins");
                    Thread.Sleep(1000);
                }

                return false;
            }

            

            

        


           



            /*
            else
            {
                if (us == "rock")
                {
                    switch (op)
                    {
                        case "paper": // LOSE
                            opponent.score += 1;
                            Console.WriteLine("Paper covers Rock!");
                            Thread.Sleep(2000);
                            Console.WriteLine("");
                            Console.WriteLine(opponent.name+" won the round!");
                            Thread.Sleep(2000);
                            break;

    */
            
                      
        }

        public void DetermineWinner()
        {
            if (playerOne.score == 2)
            {
                // P1 WIN
                Console.WriteLine(playerOne.name + " won 2/3 rounds!");
            }
            else if (opponent.score == 2)
            {
                // P2 WIN
                Console.WriteLine(opponent.name + " won 2/3 rounds!");
            }
            else
            {
                Round += 1;              
            }
        }

        public void PlayAgainPrompt()
        {
            
            
            Console.Write("Play again? ('yes') ot ('no') ");
            string input = Console.ReadLine();

            while (input != "yes" && input != "no")
            {

                Console.WriteLine("Not a valid response! Try again");
                input = Console.ReadLine();
            }

            if (input.ToLower() == "yes")
            {
                Console.Clear();
                Round = 1;
                RunGame();

                playAgain = true;
            }
            else if (input.ToLower() == "no")
            {
                Console.WriteLine("Thanks for playing!");
                Thread.Sleep(1000);
                Console.Clear();
               
                playAgain = false;
                LeaveGame();
            }
          
       

            }

        public void Shoot321()
        {
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
        }

        public void LeaveGame()
        {

            System.Environment.Exit(0);
        }


        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        // member variables (HAS A)
        public Player playerOne;
        public Player playerTwo;
        public List<Gestures> gestures;  // if you make the same list variable inside two classes, are they linked or are they different list?
       
        public int playerOneScore;
        public int playerTwoScore;


        // constructor (SPAWNER)
        public Game(Player playerOne, Player playerTwo)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;

            playerOneScore = 0;
            playerTwoScore = 0;

            Gestures rock = new Gestures("Rock");
            Gestures paper = new Gestures("Paper");
            Gestures scissors = new Gestures("Scissors");
            Gestures lizard = new Gestures("Lizard");
            Gestures spock = new Gestures("Spock");
            gestures = new List<Gestures>() { rock, paper, scissors, lizard, spock };
            //is there a way to access the list from player class without also putting it here?
            //when i don't have this list here, i get the "Object reference not set to an instance of an object error



        }



        // methods (CAN DO)


        public void Round()
        {

            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();         
            
          if ((playerOne.currentGesture.name == gestures[0].name) && (playerTwo.currentGesture.name == gestures[2].name))
            {
                Console.WriteLine("Rock crushes Scissors!");
                Console.WriteLine(playerOne.name + " wins!");
                playerOneScore++;
            }
            else if ((playerOne.currentGesture.name == gestures[0].name) && (playerTwo.currentGesture.name == gestures[3].name))
            {
                Console.WriteLine("Rock crushes Lizard!");
                Console.WriteLine(playerOne.name + " wins!");
                playerOneScore++;
            }
            else if ((playerOne.currentGesture.name == gestures[1].name) && (playerTwo.currentGesture.name == gestures[0].name))
            {
                Console.WriteLine("Paper covers Rock!");
                Console.WriteLine(playerOne.name + " wins!");
                playerOneScore++;
            }
            else if ((playerOne.currentGesture.name == gestures[1].name) && (playerTwo.currentGesture.name == gestures[4].name))
            {
                Console.WriteLine("Paper disproves Spock!");
                Console.WriteLine(playerOne.name + " wins!");
                playerOneScore++;
            }
            else if ((playerOne.currentGesture.name == gestures[2].name) && (playerTwo.currentGesture.name == gestures[1].name))
            {
                Console.WriteLine("Scissors cuts Paper!");
                Console.WriteLine(playerOne.name + " wins!");
                playerOneScore++;
            }
            else if ((playerOne.currentGesture.name == gestures[2].name) && (playerTwo.currentGesture.name == gestures[3].name))
            {
                Console.WriteLine("Scissors decapitates Lizard!");
                Console.WriteLine(playerOne.name + " wins!");
                playerOneScore++;
            }
            else if ((playerOne.currentGesture.name == gestures[3].name) && (playerTwo.currentGesture.name == gestures[1].name))
            {

                Console.WriteLine("Lizard eats Paper!");
                Console.WriteLine(playerOne.name + " wins!");
                playerOneScore++;
            }
            else if ((playerOne.currentGesture.name == gestures[3].name) && (playerTwo.currentGesture.name == gestures[4].name))
            {
                Console.WriteLine("Lizard poisons Spock");
                Console.WriteLine(playerOne.name + " wins!");
                playerOneScore++;
            }
            else if ((playerOne.currentGesture.name == gestures[4].name) && (playerTwo.currentGesture.name == gestures[2].name))
            {

                Console.WriteLine("Spock smashes Scissors!");
                Console.WriteLine(playerOne.name + " wins!");
                playerOneScore++;
            }
            else if ((playerOne.currentGesture.name == gestures[4].name) && (playerTwo.currentGesture.name == gestures[0].name))
            {
                Console.WriteLine("Spock vaporizes Rock");
                Console.WriteLine(playerOne.name + " wins!");
                playerOneScore++;
            }
            else if ((playerTwo.currentGesture.name == gestures[0].name) && (playerOne.currentGesture.name == gestures[2].name))
            {
                Console.WriteLine("Rock crushes Scissors!");
                Console.WriteLine(playerTwo.name + " wins!");
                playerTwoScore++;
            }
            else if ((playerTwo.currentGesture.name == gestures[0].name) && (playerOne.currentGesture.name == gestures[3].name))
            {
                Console.WriteLine("Rock crushes Lizard!");
                Console.WriteLine(playerTwo.name + " wins!");
                playerTwoScore++;
            }
            else if ((playerTwo.currentGesture.name == gestures[1].name) && (playerOne.currentGesture.name == gestures[0].name))
            {

                Console.WriteLine("Paper covers Rock!");
                Console.WriteLine(playerTwo.name + " wins!");
                playerTwoScore++;
            }
            else if ((playerTwo.currentGesture.name == gestures[1].name) && (playerOne.currentGesture.name == gestures[4].name))
            {
                Console.WriteLine("Paper disproves Spock!");
                Console.WriteLine(playerTwo.name + " wins!");
                playerTwoScore++;
            }
            else if ((playerTwo.currentGesture.name == gestures[2].name) && (playerOne.currentGesture.name == gestures[1].name))
            {

                Console.WriteLine("Scissors cuts Paper!");
                Console.WriteLine(playerTwo.name + " wins!");
                playerTwoScore++;
            }
            else if ((playerTwo.currentGesture.name == gestures[2].name) && (playerOne.currentGesture.name == gestures[3].name))
            {
                Console.WriteLine("Scissors decapitates Lizard!");
                Console.WriteLine(playerTwo.name + " wins!");
                playerTwoScore++;
            }
            else if ((playerTwo.currentGesture.name == gestures[3].name) && (playerOne.currentGesture.name == gestures[1].name))
            {

                Console.WriteLine("Lizard eats Paper!");
                Console.WriteLine(playerTwo.name + " wins!");
                playerTwoScore++;
            }
            else if ((playerTwo.currentGesture.name == gestures[3].name) && (playerOne.currentGesture.name == gestures[4].name))
            {
                Console.WriteLine("Lizard poisons Spock");
                Console.WriteLine(playerTwo.name + " wins!");
                playerTwoScore++;
            }
            else if ((playerTwo.currentGesture.name == gestures[4].name) && (playerOne.currentGesture.name == gestures[2].name))
            {

                Console.WriteLine("Spock smashes Scissors!");
                Console.WriteLine(playerTwo.name + " wins!");
                playerTwoScore++;
            }
            else if ((playerTwo.currentGesture.name == gestures[4].name) && (playerOne.currentGesture.name == gestures[0].name))
            {
                Console.WriteLine("Spock vaporizes Rock");
                Console.WriteLine(playerTwo.name + " wins!");
                playerTwoScore++;
            }
            else if (playerOne.currentGesture.name == playerTwo.currentGesture.name)
            {
                Console.WriteLine("It's a Tie, play again!");
            }

            Console.ReadLine();

        }
        public void DisplayRules()
        {
           

        }
        //human userinput vs. ai random input

        public void DisplayWinner()
        {
            if (playerOneScore == 3)
            {

                Console.WriteLine(playerOne.name + " wins the game!");
            }
            else if(playerTwoScore == 3)
            {
                Console.WriteLine(playerTwo.name + " wins the game!");
            }
        }

        public void RunGame()
        {
            for (int i = 0; i < 10; i++)
            {
                DisplayWinner();
                Round();               

                //if (playerOneScore == 3)
                //{
                //    Console.WriteLine(playerOne.name + " wins the game!");
                //}
                //else
                //{
                //    Console.WriteLine(playerTwo.name + " wins the game!");
                //}
            }

            

        }
    }
}

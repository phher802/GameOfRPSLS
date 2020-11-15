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
        Player playerOne;
        Player playerTwo;
        public List<Gestures> gestures;  // if you make the same list variable inside two classes, are they linked or are they different list?
        public int score;
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
            // is there a way to access the list from player class without also putting it here?



        }



        // methods (CAN DO)

        //public void CompareGestures()
        //{
        //    playerOne.ChooseGesture();
        //    playerTwo.ChooseGesture();

        //    if (gestures[0] <= gestures[2])
        //    {

        //    }


        //}


        public void Round()
        {


            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();

            int i = 0;
         

            if ((playerOne.currentGesture == gestures[i]) && (playerTwo.currentGesture == gestures[i + 2] || playerTwo.currentGesture == gestures[i + 3]))
            {
                if (playerTwo.currentGesture == gestures[i + 2])
                {
                    Console.WriteLine("Rock crushes Scissors!");
                }
                else
                {
                    Console.WriteLine("Rock crushes Lizard!");
                }
                Console.WriteLine(playerOne + "wins!");
                playerOneScore++;
            }
            else if (playerOne.currentGesture == gestures[i + 1] && (playerTwo.currentGesture == gestures[i] || playerTwo.currentGesture == gestures[i + 4]))
            {
                if (playerTwo.currentGesture == gestures[0])
                {
                    Console.WriteLine("Paper covers Rock!");
                }
                else
                {
                    Console.WriteLine("Paper disproves Spock!");
                }
                Console.WriteLine(playerOne + "wins!");
                playerOneScore++;
            }
            else if (playerOne.currentGesture == gestures[i + 2] && (playerTwo.currentGesture == gestures[i + 1] || playerTwo.currentGesture == gestures[i + 3]))
            {
                if (playerTwo.currentGesture == gestures[i + 1])
                {
                    Console.WriteLine("Scissors cuts Paper!");
                }
                else
                {
                    Console.WriteLine("Scissors decapitates Lizard!");
                }
                Console.WriteLine(playerOne + "wins!");
                playerOneScore++;
            }
            else if (playerOne.currentGesture == gestures[i + 3] && (playerTwo.currentGesture == gestures[i + 1] || playerTwo.currentGesture == gestures[i + 4]))
            {
                if (playerTwo.currentGesture == gestures[i + 1])
                {
                    Console.WriteLine("Lizard eats Paper!");
                }
                else
                {
                    Console.WriteLine("Lizard poisons Spock");
                }
                Console.WriteLine(playerOne + "wins!");
                playerOneScore++;
            }
            else if (playerOne.currentGesture == gestures[i + 4] && (playerTwo.currentGesture == gestures[i + 2] || playerTwo.currentGesture == gestures[i]))
            {
                if (playerTwo.currentGesture == gestures[i + 2])
                {
                    Console.WriteLine("Spock smashes Scissors!");
                }
                else
                {
                    Console.WriteLine("Spock vaporizes Rock");
                }
                Console.WriteLine(playerOne + "wins!");
                playerOneScore++;
            }
            else if (playerTwo.currentGesture == gestures[i] && (playerOne.currentGesture == gestures[i + 2] || playerOne.currentGesture == gestures[i + 3]))
            {
                if (playerOne.currentGesture == gestures[i + 2])
                {
                    Console.WriteLine("Rock crushes Scissors!");
                }
                else
                {
                    Console.WriteLine("Rock crushes Lizard!");
                }
                Console.WriteLine(playerTwo + "wins!");
                playerTwoScore++;
            }
            else if (playerTwo.currentGesture == gestures[i + 1] && (playerOne.currentGesture == gestures[i] || playerOne.currentGesture == gestures[i + 4]))
            {
                if (playerOne.currentGesture == gestures[i])
                {
                    Console.WriteLine("Paper covers Rock!");
                }
                else
                {
                    Console.WriteLine("Paper disproves Spock!");
                }
                Console.WriteLine(playerTwo + "wins!");
                playerTwoScore++;
            }
            else if (playerTwo.currentGesture == gestures[i + 2] && (playerOne.currentGesture == gestures[i + 1] || playerOne.currentGesture == gestures[i + 3]))
            {
                if (playerOne.currentGesture == gestures[i + 1])
                {
                    Console.WriteLine("Scissors cuts Paper!");
                }
                else
                {
                    Console.WriteLine("Scissors decapitates Lizard!");
                }
                Console.WriteLine(playerTwo + "wins!");
                playerTwoScore++;
            }
            else if (playerTwo.currentGesture == gestures[i + 3] && (playerOne.currentGesture == gestures[i + 1] || playerOne.currentGesture == gestures[i + 4]))
            {
                if (playerOne.currentGesture == gestures[i + 1])
                {
                    Console.WriteLine("Lizard eats Paper!");
                }
                else
                {
                    Console.WriteLine("Lizard poisons Spock");
                }
                Console.WriteLine(playerTwo + "wins!");
                playerTwoScore++;
            }
            else if (playerTwo.currentGesture == gestures[i + 4] && (playerOne.currentGesture == gestures[i + 2] || playerOne.currentGesture == gestures[i]))
            {
                if (playerOne.currentGesture == gestures[i + 2])
                {
                    Console.WriteLine("Spock smashes Scissors!");
                }
                else
                {
                    Console.WriteLine("Spock vaporizes Rock");
                }
                Console.WriteLine(playerTwo + "wins!");
                playerTwoScore++;
            }
            else if(playerOne.currentGesture == gestures[i] && playerTwo.currentGesture == gestures[i])
            {
                Console.WriteLine("It's a tie!");
            }

        }
        public void DisplayRules()
        {

        }
        //human userinput vs. ai random input

    }
}

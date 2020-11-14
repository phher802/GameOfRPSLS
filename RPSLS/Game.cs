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
        public List<Player> players;
      

        // constructor (SPAWNER)
        public Game(Player playerOne, Player playerTwo)
        {
          
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;

            playerOneScore = 0;
            playerTwoScore = 0;

            players = new List<Player>();
            players.Add(this.playerOne);
            players.Add(this.playerTwo);

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

            if (playerOne.currentGesture == gestures[0] && playerTwo.currentGesture == gestures[2] || playerOne.currentGesture == gestures[0] && playerTwo.currentGesture == gestures[3])
            {
                Console.WriteLine(playerOne + "wins!");
                playerOneScore++;
            }         
            else if (playerOne.currentGesture == gestures[1] && playerTwo.currentGesture == gestures[0] || playerOne.currentGesture == gestures[1] && playerTwo.currentGesture == gestures[4])
            {
                Console.WriteLine(playerOne + "wins!");
                playerOneScore++;
            }
            else if (playerOne.currentGesture == gestures[2] && playerTwo.currentGesture == gestures[1] || playerOne.currentGesture == gestures[2] && playerTwo.currentGesture == gestures[3])
            {
                Console.WriteLine(playerOne + "wins!");
                playerOneScore++;
            }
            else if (playerOne.currentGesture == gestures[3] && playerTwo.currentGesture == gestures[1] || playerOne.currentGesture == gestures[3] && playerTwo.currentGesture == gestures[4])
            {
                Console.WriteLine(playerOne + "wins!");
                playerOneScore++;
            }
            else if (playerOne.currentGesture == gestures[4] && playerTwo.currentGesture == gestures[2] || playerOne.currentGesture == gestures[4] && playerTwo.currentGesture == gestures[0])
            {
                Console.WriteLine(playerOne + "wins!");
                playerOneScore++;
            }

        }
        public void DisplayRules()
        {

        }
        //human userinput vs. ai random input

    }
}

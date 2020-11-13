using System;
using System.Collections.Generic;
using System.Linq;
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

        public Gestures rockWins;
        public Gestures paperWins;
        public Gestures scissorWins;
        public Gestures lizardWins;
        public Gestures spockWins;

        // constructor (SPAWNER)
        public Game(Player playerOne, Player playerTwo)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;

            playerOneScore = 0;
            playerTwoScore = 0;
        }



        // methods (CAN DO)

        //public void CompareGestures()
        //{
           

        //    if (playerOne.ChooseGesture() == gestures[0] && playerTwo.currentGesture == gestures[2])
        //    {
        //        Console.WriteLine(playerOne + "wins!");
        //        playerOneScore++;

        //    }else if (playerOne.currentGesture == gestures[0] && playerTwo.currentGesture == gestures[3])
        //    {
        //        Console.WriteLine(playerOne + "wins!");
        //        playerOneScore++;
        //    }


        //}

        public void Round()
        {
            
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();



        }
        public void DisplayRules()
        {

        }
        //human userinput vs. ai random input

    }
}

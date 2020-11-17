using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerOne = new Human("pa");
            Player playerTwo = new AI("Nano");

            //AI ai = new AI();
            //Human human = new Human("pa");
            ////human.ChooseGesture();
            //human.UserInput();
            //playerOne.ChooseGesture();

            Game game = new Game(playerOne, playerTwo);
            game.RunGame();
            //game.CompareGestures();

            //ai.ChooseGesture();

        }
    }
}

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
            Player playerOne = new Human();
            Player playerTwo = new AI();
           
            AI ai = new AI();
            Human human = new Human();
            //human.ChooseGesture();
            //human.UserInput();
            //playerOne.ChooseGesture();

            Game game = new Game(playerOne, playerTwo);
            game.Round();
            //game.CompareGestures();

            //ai.ChooseGesture();

        }
    }
}

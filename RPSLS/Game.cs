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
        public List<Gestures> gestures;

        // constructor (SPAWNER)
        public Game()
        {
            gestures = new List<Gestures>();

            Gestures rock = new Gestures("rock");
            Gestures paper = new Gestures("paper");
            Gestures scissor = new Gestures("scissor");
            Gestures lizard = new Gestures("lizard");
            Gestures spock = new Gestures("spock");
            gestures = new List<Gestures>() { rock, paper, scissor, lizard, spock };




        }



        // methods (CAN DO)
    }
}

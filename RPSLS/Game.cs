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

            Gestures rock = new Gestures();
            Gestures paper = new Gestures();
            Gestures scissor = new Gestures();
            Gestures lizard = new Gestures();
            Gestures spock = new Gestures();
            gestures = new List<Gestures>() { rock, paper, scissor, lizard, spock };




        }



        // methods (CAN DO)
    }
}

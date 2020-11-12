using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        // member variables (HAS A)
        public string name;
        public int score;
        public string currentGesture;
        public List<Gestures> gestures;

        // constructor (SPAWNER)
        public Player()
        {           
            Gestures rock = new Gestures("Rock");
            Gestures paper = new Gestures("Paper");
            Gestures scissor = new Gestures("Scissor");
            Gestures lizard = new Gestures("Lizard");
            Gestures spock = new Gestures("Spock");
            gestures = new List<Gestures>() { rock, paper, scissor, lizard, spock };
        }


        // methods (CAN DO)
        public abstract void ChooseGesture();

    }
}

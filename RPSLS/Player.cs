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
            gestures = new List<Gestures>();

            Gestures rock = new Gestures("rock");
            Gestures paper = new Gestures("paper");
            Gestures scissor = new Gestures("scissor");
            Gestures lizard = new Gestures("lizard");
            Gestures spock = new Gestures("spock");
            gestures = new List<Gestures>() { rock, paper, scissor, lizard, spock };
        }


        // methods (CAN DO)
        public abstract void ChooseGesture();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI : Player
    {
        // member variables (HAS A)
        Random random;


        // constructor (SPAWNER)
        public AI(string name)
        {
            random = new Random();
            this.name = name;
        }


        // methods (CAN DO)
        public override void ChooseGesture()
        {
     
            int rando = random.Next(gestures.Count);
            currentGesture = gestures[rando];
         
            Console.WriteLine(name + " chose " + currentGesture.name);              
            Console.ReadLine();
        }

       
    }
}

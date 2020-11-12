using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        // member variables (HAS A)



        // constructor (SPAWNER)
        public Human(string name)
        {
            this.name = name;
        }

        // methods (CAN DO)
        public override void ChooseGesture()
        {
            //display list
            //prompt player to choose from list
           
            Console.WriteLine("Moves");
            foreach (Gestures gesture in gestures)
            {
                Console.WriteLine(gesture.name);
            }

            Console.ReadLine();
        }

    }
}

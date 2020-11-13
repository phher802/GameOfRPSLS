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
        public AI()
        {
            random = new Random();

        }


        // methods (CAN DO)
        public override void ChooseGesture()
        {


            for (int i = 0; i < 5; i++)
            {
                //int gesture = int.Parse(Console.WriteLine(gestures[i].name));
                //gesture = (gestures[i].name);
                random.Next(i);

            }


            Console.ReadLine();
        }

        public void RandomGesture()
        {


            for (int i = 0; i < 5; i++)
            {
                int rando = random.Next(i);
                Console.WriteLine(rando);
            }

            Console.ReadLine();
            

        }
    }
}

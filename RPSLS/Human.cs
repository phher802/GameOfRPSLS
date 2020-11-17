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
            DisplayList();      
            UserInput();
            Console.WriteLine( name + " chose " + currentGesture.name);
        }

     
        public void UserInput()
        {
            Console.WriteLine("Choose a gesture to play by entering the number next to the gesture");
            int userInput = int.Parse(Console.ReadLine());

            while (userInput >= 5) 
            {
                Console.WriteLine("Pick a number from 0 to 4");
                userInput = int.Parse(Console.ReadLine());
            }

            currentGesture = gestures[userInput];
            

        }
        public void DisplayList()
        {

            Console.WriteLine("Your available gestures");
            Console.WriteLine(" ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(gestures[i].name + " " + i);
            }

            Console.ReadLine();
        }
    }
}

﻿using System;
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

            //Console.WriteLine("Choose a gesture to play by entering the number next to the gesture");
            //int userInput = int.Parse(Console.ReadLine());
            //currentGesture = gestures[userInput];

            //for (int i = 0; i < 5; i++)
            //{
            //   (Console.WriteLine(gestures[i].name)
            //}


            //Console.WriteLine("You Chose " + );
        }

        public void UserInput()
        {
            Console.WriteLine("Choose a gesture to play by entering the number next to the gesture");
            int userInput = int.Parse(Console.ReadLine());
            currentGesture = gestures[userInput];

        
            Console.WriteLine("you chose " + currentGesture.name);
            Console.ReadLine();

            //Console.WriteLine("You Chose " + userInput);
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

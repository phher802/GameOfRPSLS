﻿using System;
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
            Player playerOne = new Human("pa");
            Player playerTwo = new AI("Nano");

          

            Game game = new Game(playerOne, playerTwo);
            game.RunGame();
         
        }
    }
}

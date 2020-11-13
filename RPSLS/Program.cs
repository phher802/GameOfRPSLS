using System;
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
           
            AI ai = new AI();

            //playerOne.ChooseGesture();
            ai.RandomGesture();
            

          
        }
    }
}

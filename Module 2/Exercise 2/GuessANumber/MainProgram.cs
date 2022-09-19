using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// The starting class.  It starts an object of
    /// the game GuessTheNumber.
    /// </summary>
    class MainProgram
    {
        static void Main (string[] args)
        {
            // Set title in console window
            Console.Title = "Guess the Number";

            // Instantiate and start Menu object
            GuessTheNumber game = new GuessTheNumber ( );
            game.Start ( );

        }
    }
}

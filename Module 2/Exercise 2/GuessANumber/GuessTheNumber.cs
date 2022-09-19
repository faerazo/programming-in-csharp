//GuessTheNumber.cs 
//Created:    By:         April 20, 2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// This class represents a simple game.  An object of this
    /// class generates a random number between 0 and 99 and 
    /// lets the user guess the number.
    /// </summary>
    class GuessTheNumber
    {
        private Random random = new Random ( );
        
        /// <summary>
        /// Start the game and then runs a loop until the user 
        /// chooses to exit.
        /// Show some information.
        /// Start Playing.
        /// After each round, ask the use to continue or exit.
        /// 
        /// </summary>
        public void Start ( )
        {
            bool play = true; //flag to decide to continue or not
           
            //Display some info about the game
            DisplayGameInfo ( );
  
            //Run a loop.  play is true at the beginning
            //The loop runs at least once.
            while (play)
            {
                PlayGame ( );
                play = PlayAgain ( );
            }

            Console.WriteLine ( "Please kam-bak!" );
        }

        /// <summary>
        /// Play one round.
        /// Randomize an integer number between 0 and 99.
        /// The Random class in C# has several methods: The Next method gives an int
        /// between a start and an end limit (not including the upper limit).
        /// </summary>
        private void PlayGame()
        {
            bool done = false;

            int randNum = random.Next (0, 100 ) ;
            int attempt = 0;  //unlimited number of attempts

            do
            {
                attempt++;

                string message = string.Format("Attempt no. {0, 2}, Your guess (0 - 99): ", attempt );

                //Get the user's number
                int userNum = Input.ReadIntegerConsole ( message);

                if (userNum == randNum)
                {
                    done = true;
                    Console.WriteLine ( );
                    Console.WriteLine ( " ++++++++  Congratulations! +++++++++" );
                }
                else if (userNum > randNum)
                    Console.WriteLine ( "Too high!" );
                else
                    Console.WriteLine ( "Too low!" );

            } while (!done);
          }
        
        /// <summary>
        /// PlayAgain 
        /// Ask the user to continue or exit.
        /// </summary>
        /// <returns>return true if user answers 'y' or false otherwise.</returns>
        private bool PlayAgain()
        {
            Console.WriteLine ( );
            Console.Write ( "Play again (y/n)? " );
            char response = char.Parse ( Console.ReadLine ( ) );

            if ((response == 'y') || (response == 'Y'))
                return true;
            else
                return false;
       }
        /// <summary>
        /// Display game info.
        /// </summary>
        private void DisplayGameInfo ( )
        {
            Console.WriteLine ( );
            Console.WriteLine ( "------------------ GUESS THE NUMBER -------------------" );
            Console.WriteLine ( "   The computer selects a random value between 0 and 99" );
            Console.WriteLine ( "   You have guesss the number. The game will help you" );
            Console.WriteLine ( "   by letting you know if the guess number is too high" );
            Console.WriteLine ( "   or too low! It also displays the number of attempts." );
            Console.WriteLine ( "   the game stops and you replay." );
            Console.WriteLine ( "------------------ GUESS THE NUMBER -------------------" );
            Console.WriteLine ( );
        }       

    }
}

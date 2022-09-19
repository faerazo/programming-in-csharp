// Menu.cs
// Created:   Farid Naisan, Sept 15th 2016
// Revised:  
// Purpose: This class demos how a menu can be shown on a console window.
//          The menu continues until the user chooses to exit.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InputProgram
{
    class Menu
    {
        /// <summary>
        /// This class works as a user-interface
        /// Shows a menu and reads the use choice of how to show the 
        /// current time, date or both
        /// </summary>
        public void ShowMenu ( )
        {
            bool done = false;  //Flag to control when to exit the loop

            while (!done)  //done is false at the beginning
            {
                int number = Input.ReadIntegerConsole ( "Give a non-zero number to continue, 0 to exit: " );
                if (number == 0)
                    done = true;
                else
                    Console.WriteLine ( "Good number!" );
            }
        }
			      
    }//class
} //namespace

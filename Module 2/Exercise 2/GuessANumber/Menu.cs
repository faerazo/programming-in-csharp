using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// Purpose:    This class contains the logic to display the menu and handle user interactions.
    ///             The user selects one of the listed choices. Each choice instantiates an object
    ///             providing different functionalities. After the functionality is performed, the 
    ///             menu is displayed again for another choice. 
    ///             The option 'zero' terminates the Menu.
    /// </summary>
    class Menu
    {
        public void Start ( )
        {
            int choice = -1;

            while (choice != 0)
            {
                DisplayMenu ( );  //Show the menu
                
                //Read user's choice
                choice = Input.ReadIntegerConsole ( " Your choice: " );

                //Depending on the value of the choice, create an instance of the 
                //the class displayed on the menu.
                switch (choice)
                {
                    case 2:  //Menu item 1 (The for-statement)
                        {
                            // Declare a local reference variable and
                            // create an instance of WholeNumbersFor
                            TemperatureConverter tempConverter = new TemperatureConverter ( );

                            //call the objects start method
                            tempConverter.Start ( );
                            break;
                        }
                    // Continue...

                    case 1:
                        {
                            GuessANumber play = new GuessANumber ( );
                            play.Start ( );
                            break;
                        }
                    
                    case 3:
                        {
                            WorkingSchedule schedule = new WorkingSchedule ( );
                            schedule.Start ( );
                            break;
                        }
                    default:
                        Console.WriteLine ( "Select a value between 0 and 4." );
                        Console.WriteLine ( );
                        break;
                }

                Console.WriteLine ( "\n" );

            } //while (choice
        } //void start

        public void DisplayMenu ( )
        {
            Console.Title = "Selection and iteration algorithms";
            Console.WriteLine ( "------------------------------------------------" );
            Console.WriteLine ( "                  MAIN MENU" );
            Console.WriteLine ( "------------------------------------------------" );
            Console.WriteLine ( "   Play the game Guess a Number    : 1" );
            Console.WriteLine ( "   Temperature converter           : 2" );
            // Console.WriteLine( "   Work Schedule                   : 3" );
            Console.WriteLine ( "   Exit the program                : 0" );
            Console.WriteLine ( "------------------------------------------------" );
         }

    }//class* /

} //namespace
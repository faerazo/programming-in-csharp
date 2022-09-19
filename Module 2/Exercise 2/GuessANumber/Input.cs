//Input.cs 
//Created:    By:         Sometimes in the past!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{

    /// <summary>
    /// This is a class with static methods that are used to check the user's input
    /// and make sure that it belongs to the type that the calling methods needs.
    /// The caller methods do not need ti instantiate this class because 
    /// static methods are called directly by the class name.
    /// int goodNUmber = Input.ReadIntegerConsole("Give a number: ");
    /// </summary>
    /// <remarks></remarks>
    /// 
    public class Input
    {
        public static int ReadIntegerConsole (string messageToUser)
        {
            // Reads from the console until a correct integer is received
            bool goodNumber = false;
            int convertedValue = 0;

            do
            {
                //Show the message (method parameter) to the user
                Console.Write ( messageToUser );

                goodNumber = int.TryParse ( Console.ReadLine ( ), out convertedValue );

                if (!goodNumber)
                    Console.Write ( "Invalid input. Please try again: " );
            } while (!goodNumber);

            return convertedValue;
        }

        /// <summary>
        /// The methods reads a double value from the console.
        /// No message is given to the user at the beginning.
        /// Thre is a recursive call in this method, that eliminates
        /// the need for a loop.  Remember: recursive calls should be
        /// used only in certain algorithms.  Use loops as much as 
        /// possible. Here, it is for the purpose of a demo. 
        /// </summary>

        public static double ReadDoubleConsole ( )
        {
            // Reads from the console until a correct double is received
            double input = 0;
            if (double.TryParse ( Console.ReadLine ( ), out input ))
            {
                return input;
            }
            else
            {
                Console.Write ( "Wrong input. Please try again: " );
                return ReadDoubleConsole ( );
            }
        }

        /// The methods reads a decimal value from the console.
        /// No message is given to the user at the beginning.
        /// Thre is a recursive call in this method, that eliminates
        /// the need for a loop.  Remember: recursive calls should be
        /// used only in certain algorithms.  Use loops as much as 
        /// possible. Here, it is for the purpose of a demo. 

        public static decimal ReadDecimalConsole ( )
        {
            // Reads from the console until a correct decimal is received
            decimal input = default ( decimal );
            if (decimal.TryParse ( Console.ReadLine ( ), out input ))
            {
                return input;
            }
            else
            {
                Console.Write ( "Wrong input. Please try again: " );
                return ReadDecimalConsole ( );
            }
        }

    }


}

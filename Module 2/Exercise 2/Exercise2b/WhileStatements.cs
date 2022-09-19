using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2b
{
    class WhileStatements
    {
        //Input:  Number whose square root is to be calculated
        private double number;

        public void Start()
        {
            bool calcAgain = true;

            //Calculate the root of a number given by the user
            //continue until the user decides to exit 
            do
            {
                ReadNumber();
                CalculateRoot();

                calcAgain = CalculateAgain();

            } while (calcAgain);
        }//end of Start
    

    //Read user's input, a number to calculate the square root of
    private void ReadNumber()
    {
        Console.Write("Please write a valid number: ");

        //Read user input, from the cursor position to end of line
        //Save the line (text) in a temporary string variable
        string str = Console.ReadLine();

        //Convert str to a number of double type.
        //The user is assumed to give the text in correct number format.
        number = double.Parse(str);  
    }

    //Calculate the square root of the value saved in the variable, number
    //Display the result
    private void CalculateRoot()
    {
        if (number >= 0)
        {
            double root = Math.Sqrt(number);
            Console.WriteLine("The square root of " + number + " is:" + root.ToString("0.00"));
        }
        else  //negative number
            Console.WriteLine("Negataive number do not have a real square root!");
    }

    //Ask user to whether to continue, 
    //return true if the user answers Y, y or any word beginning
    //with these, or N, n or any word beginning with these. 
    //Otherwise, return false.
    private bool CalculateAgain()
    {
        bool answer = false; //true = y, false = n

        Console.WriteLine(); //blankline
        Console.Write("Do you want to continue? ");

        bool goodAnswer = false; //make user answer correctly
            do
            {
                string str = Console.ReadLine();
                //change str to capital letters to make comparison 
                //easier
                str = str.ToUpper();

                if (str[0] == 'Y')   //str[0]is the first letter in the string
                {
                    answer = true;  // continue wit
                    goodAnswer = true;
                }
                else if (str[0] == 'N')
                {
                    answer = false;  // do not continue with calculation 
                    goodAnswer = true;
                }
                else //anything else
                {
                    Console.WriteLine("Please use Y/N or y/n!");
                    goodAnswer = false;
                }

            } while (!goodAnswer);   //if (!goodAnswer) is same as: if (goodAnswer == false)

            return answer;
        }
    }
}

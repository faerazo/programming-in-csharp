// Month.cs
// Created:   Farid Naisan, 2006-07-03
// Revised:   Farid Naisan, 2008-06-13, minor changes in comments
// Revised:   2014-09-04  coorctions in leap year calculations
// Revised:   2015-11-24  Reading of year as input takes place only if month = 2 (feb)
// Purpose:   This class gives exercise in local variables, methods with
//            and without parameters, iterations with for and while,
//            and conditinoal statemetn with both switch and if-else.


// Assumptions:  No skills in Properties, constructors, arrays

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaysOfMonthAppCS
{
    /// <summary>
    /// Class that calculates the number of days in a month with
    /// leap year accounted for.
    /// </summary>
    public class Month
    {
        // This class doesn't have any field (instance variables) 

        /// <summary> 
        /// Starts a calculation of days of a months in given year 
        /// Runs a loop until the user inputs a 0 value 
        /// </summary> 
        /// <remarks></remarks> 
        public void Start()
        {
            //Local variables 
            int month;    //input a value between 1=Jan and 12= Dec 
            int year;     //input a value between say 1900 to 3000 

            int days = 0; //output: number of days calculated
            bool proceed = true;     //flag to detect if the user will continue

            //The program runs until the user gives the number 0. 
            while (proceed)  //is same as while (proceed == true)
            {
                 //Allow values  0, 1, 2 ... 12  (1 to 12 months, 0 to exit the loop and the program)
                month = ReadAnIntegerValue("Write your favorite month, 1 to 12 or 0 to terminate: ", 0, 12);

                if (month <= 0)
                    proceed = false;   //user has given 0 to end the program 
                else
                {
                    if (month == 2) //reading the year is required
                        year = ReadAnIntegerValue ( "Which year (1900 to 3000)? ", 1900, 3000 );
                    else
                        year = DateTime.Now.Year; //actually year can be any value 
                    
                    //Start calculation and give the output (num of days) 
                    days = CalculateDays(month, year);
                    ShowOutput(days, month, year);

                    Console.WriteLine();        //blank line 
                }
            }
        }

        /// <summary> 
        /// Read an integer value from the console. 
        /// 
        /// </summary> 
        /// <param name="messageToUser">Information given to user.</param> 
        /// <param name="min">The value should be >= min.</param> 
        /// <param name="max">The value should be less than or equal to max.</param> 
        /// <returns>The integer value read from the console.</returns> 
        /// <remarks></remarks> 

        private int ReadAnIntegerValue(string messageToUser, int min, int max)
        {
            bool done = false; //initiation 
            int value = 0;  //for the input

            while (!done)
            {
                //perform iteration until the user gives a valid number 
                Console.Write(messageToUser);

                string text = Console.ReadLine(); //get the input (string) 

                //Convert the string to an integer "12" (string) to 12 (number)
                //The value param gets a value of the function call if the string can be
                //converted to a number, otherwise it gets 0 and the call returns false.

                if ( int.TryParse (text, out value ) )   
                {
                    //The variable value is a valid number representation.
                    //Now control the limits
                    if ( (value >= min) && (value <= max) )
                    {
                        done = true;  //Input is OK 
                    }
                }

                //done is true only if everything goes well 
                if (!done)
                {
                    Console.WriteLine("Not a good one. Try again buddy!");
                }

            }

            return value;
        }

        /// <summary> 
        /// Calculates the number of days in a given month,for a given year. 
        /// </summary> 
        /// <param name="month">Input - a given month.</param> 
        /// <param name="year">Input - a given year.</param> 
        /// <returns>The number of days for the given month and year.</returns> 
        /// <remarks></remarks> 
        public int CalculateDays(int month, int year)
        {
            switch (month)
            {
                //jan, march,may,july,oct & dec 
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;  //break or return can be used

                case 2: //february 
                    if (IsLeapYear(year))
                        return 29;
                    else
                        return 28;
 
                case 4:
                case 6:
                case 9:
                case 11:  //apr, jun, sep,nov 
                    return 30;

                default:
                    Console.WriteLine("Wrong input!");
                    return 0;
            }

        }

        //A year will be a leap year if it is divisible by 4 but not by 100. 
        //If a year is divisible by 4 and by 100, it is not a leap year unless 
        //it is also divisible by 400.
            private bool IsLeapYear(int year)
        {
            bool leapYear;
            leapYear = ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
            return leapYear;
        }

        /// <summary> 
        /// Write out the results. 
        /// </summary> 
        /// <param name="days">The calculated number of days.</param> 
        /// <param name="month">The month, user input</param> 
        /// <param name="year">The year, user input.</param> 
        /// <remarks></remarks> 
        private void ShowOutput(ValueType days, int month, int year)
        {
            Console.WriteLine();
            char padChar = Convert.ToChar("+");     //Why? 
            PadLineWithChar(padChar, 15, false);    //let the cursor stay on the line 
            Console.Write(" THE RESULTS ");
            PadLineWithChar(padChar, 15); //Overloaded method called - Move the cursor to next line 

            string textOut = string.Format("Number of days for {0} in {1}is: {2}.", month, year, days);
            Console.WriteLine(textOut);
            PadLineWithChar(Convert.ToChar("+"), 46);
            Console.WriteLine();
        }


        /// <summary> 
        /// Draw a line with count characters using the given character 
        /// </summary> 
        /// <param name="symbol">The character to write the line with.</param> 
        /// <param name="count">The number of the times</param> 
        /// <param name="newLine">If the cursor is to be moved to next line.</param> 
        /// <remarks></remarks> 
        public void PadLineWithChar(char symbol, int count, bool newLine)
        {
            //Write out count the symbol count times 
            for (int i = 0; i <= count; i++)
                Console.Write(symbol);

            if (newLine)
                Console.WriteLine(); //move to next line 
        }

        /// <summary> 
        /// Overloaded method calling PadLinewithChar that has 3 parameter''' 
        /// </summary> 
        /// 
        /// <param name="symbol">The character to write the line with.</param> 
        /// <param name="count">The number of the times</param> 
        /// <remarks>Newline is set to true by default.</remarks> 

        public void PadLineWithChar(char symbol, int count)
        {
            PadLineWithChar(symbol, count, true); //calls the above method with newLine=true 
        }
    } 
}

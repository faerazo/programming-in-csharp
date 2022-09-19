//MonthsProg.cs
//Created:  Farid Naisan, 2006-07-03
//Revised:  Farid Naisan, 2008-06-13, minor changes in comments
//Purpose:  This class tests the class Months.cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// This program calculates the number of days in a month for a given year. 
/// The program checks if the year is a leap year to determine the correct
/// number of days in February.
/// </summary>
/// <remarks></remarks>
namespace DaysOfMonthAppCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Days of months in any year";
            //Declare and create an instance (an object) of the class Months
            Month monthObj = new Month();

            //Call the start method of month object
            monthObj.Start();

            //Console.ReadKey();

        }
    }
}

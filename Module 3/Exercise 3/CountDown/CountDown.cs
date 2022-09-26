//Code Example:
//Created by Farid Naisan, Jan 2012

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComboBoxEx
{
    /// <summary>
    ///  A struct that handles the time difference between a due date
    ///  and now. 
    /// </summary>
    struct CountDown
    {
        DateTime dueDate;  //Time to count down to.

        /// <summary>
        /// Constructor expecting the the due date as a parameter
        /// </summary>
        /// <param name="dueDate">Date to count down to.</param>
        /// <remarks></remarks>
        public CountDown(DateTime dueDate)
        {
            this.dueDate = dueDate;

        }

   /// <summary>
    /// Calculate the time left from this moment  to due date,
    /// </summary>
    /// <param name="calcOption">Choice of the unit to express the 
    /// time left into.</param>
    /// <returns>The time left according to the option chosen (days, minutes,etc.</returns>
    /// <remarks></remarks>

        public  string CalcDateTimeLeft(DisplayOptions option)
        {
            DateTime nowDate = DateTime.Now;

            TimeSpan dateDifference = dueDate - nowDate;
            double difference = 0.0;
            string unit = String.Empty;

            switch (option)
            {
                case DisplayOptions.TotalDays:
                    difference = dateDifference.TotalDays;
                    unit = "days";
                    break;

                case DisplayOptions.TotalMinutes:
                    difference = dateDifference.TotalMinutes;
                    unit = "minutes";
                    break;

                case DisplayOptions.TotalSeconds:
                    difference = dateDifference.TotalSeconds;
                    unit = "seconds";
                    break;

                case DisplayOptions.LongDateTimeFormat:
                    string strMsg = String.Format("{0,1:f0} days, {1,1:f0} hours, {2,1:f0} minutes and {3,1:f0} seconds left.",
                        dateDifference.Days, dateDifference.Hours, dateDifference.Minutes, dateDifference.Seconds);
                    return strMsg;
                    
            }

            return String.Format("Time left: {0} {1}", Math.Round(difference,0).ToString(), unit);
        }
    }
}
    
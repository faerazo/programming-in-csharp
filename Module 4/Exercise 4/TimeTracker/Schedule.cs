//Code Example - Farid Naisan
//Created:  2014-10-10 by Farid Naisan

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTracker
{
    /// <summary>
    /// Schedule to keep track of the of the name of hours in a scheduled task.
    /// In this version, the schedule works only for one year.
    /// TotNumofRows = number of days in the chosen month.
    /// The number of days is calculted for the leap years.
    /// It should be calculated everytime to make sure the value
    /// is updated as the user changes the month on the GUI
    /// 
    /// </summary>
    public class Schedule
    {
        //fileds (DateTime is not a good alternative here, because you can't change
        //day, year or month. )
        private int m_day;
        private int m_month;
        private int m_year;

        private const int totNumOfCols = 12;    //months of the year
        
        //two-dim array for storing number of hrs per week
        private double[,] timeTable;            


        //Default Constructo
        //Initialize date to today.
        public Schedule()
        {
            //Set defaultvalue
            m_day = DateTime.Now.Day;
            m_month = DateTime.Now.Month;
            m_year = DateTime.Now.Year;
            
            //CreateTable  
            int totNumOfRows = CalculateDays();
            timeTable = new double[totNumOfRows, totNumOfCols];
        }

        //properties
        public int Day 
        { 
            get
            {
                //Important to validate the days of the month
                if (!ValidateDay(m_day))
                    m_day = 1;

                return m_day;   //first day of month
            }
            set
            {
                if (ValidateDay(value))
                    m_day = value;
            }
        }
 
        public int Month
        {
            get { return m_month; }
            set
            {
                if ((value >= 1) && (value <= 12))
                    m_month = value;
            }
        }

        public int Year
        {
            get
            {
                return m_year;
            }
            set
            {
                if ((value >= 1) && (value < 9999))
                    m_year = value;
            }
        }
       /// <summary>
        /// ReadOnly property
        /// Total number of days in a month
        /// </summary>
        public int MonthDays
        {
            get
            {
               return CalculateDays();
            }
        }
        
     /// <summary>
        /// Property connected to totNumOfCols
        /// </summary>
        public int TotalNumOfCols
        {
            get
            {
                return TotalNumOfCols;
            }

        }        
        
        /// <summary>
        /// Day must be correct with considerations of the 
        /// leap years.
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        public bool ValidateDay(int day)
        {
            return (day >= 1) && (day <= CalculateDays());
        }
 
        /// <summary>
        /// Save hours worked on a certain day and a month,
        /// in the 2-dimensional array.  Value can be positive,
        /// negative or zero.
        /// </summary>
        /// <param name="newValue">Value to be added.</param>
        public void AddNewValueInTable(double newValue)
        {
            //check if week and day are valid
            //The -d array beginning from [0,0]
            int row = m_day-1;  
            int col = m_month-1;

            //Add the value
            timeTable[row, col] = newValue;

        }

        /// <summary>
        /// Sum up the hours saved in the timetable.
        /// </summary>
        /// <returns></returns>
        public double GetSumOfHoursForMonth()
        {
            double sum = 0;
            int totNumOfRows = CalculateDays();

            for (int row = 0; row < totNumOfRows; row++)
            {
                for (int col = 0; col < totNumOfCols; col++)
                {
                    sum += timeTable[row, col];
                }
            }

            return sum;
        }


        /// <summary>
        /// Prepare a one dimensional array of string elements.
        /// Each element contains the hour for one day (one row on the table) 
        /// for all months (jan  to dec - see the GUI when running the application).
        /// Entries that do not have a value are marked with 0
        ///  1  |  0  | 4.5 |  0  |  0  |  0  |  0  |  0  |  0  | 0  |  0  |  0  |  0  |
        ///  The Last row is the name of the months (see the GUI when running)
        /// </summary>
        /// <returns></returns>
        public string[] GetAllTableRowsAsStringArray()
        {
            int totNumOfRows = CalculateDays();
            string[] infoStrings = new string[totNumOfRows+2]; //+2 for the title and a blank line

            int row = 0;
            for ( row = 0; row < totNumOfRows; row++)  //could use nameDateTable.GetLength(0)
            {
                
                string formatText = String.Format("{0,2} |", row + 1);

                for (int col = 0; col < totNumOfCols; col++)  //nameDateTable.GetLength(1)
                {
                    if (timeTable[row, col] > 0.0)
 
                        formatText += String.Format("{0,6:1f} |", timeTable[row, col].ToString("0.0"));
                    else
                        formatText += String.Format(" {0,5} |", "  0  ");        
                }

                infoStrings[row] = formatText;
            }
            infoStrings[row++] = ""; 
            infoStrings[row] = "Day:";

            string [] dayStrings = Enum.GetNames(typeof(MonthsOfYear));

            foreach (string day in dayStrings)
                infoStrings[row] += String.Format("  {0,4} |", day);

           // infoStrings[row] = "Day   Jan    Feb     Mar     Apr      May    Jun     Jul     Aug      Sep     Oct      Nov     Dec";
            return infoStrings;
        }


        /// <summary> 
        /// Calculates the number of days in a given day,for a given year. 
        /// If the year is a leap year, days in feb will be 29.
        /// </summary> 
         /// <returns>The number of days for the given day and year.</returns> 
        /// <remarks></remarks> 
        public int CalculateDays()
        {
            switch (m_month)
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
                    if (IsLeapYear(m_year))
                        return 29;
                    else
                        return 28;

                case 4:
                case 6:
                case 9:
                case 11:  //apr, jun, sep,nov 
                    return 30;

                default:

                    return 31;
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
    }
}

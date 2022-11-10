//Code example
//Farid Naisan

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimerExample
{
    /// <summary>
    /// This class handles the logics for a small game in which the user should 
    /// hit a target (image) when it is randomly displayed on a panel.
    /// The class defins variables that store the statistics about the game for a
    /// session.
    /// 
    /// </summary>
    /// <remarks>ToDo:  Study every single method and every property in this class.  
    /// Comments all methods and also the code lines which you find unclear.
    /// </remarks>
    public class CatchMe
    {
        /// <summary>
        /// Game variables.
        /// The modifier "readonly" makes the variable almost like a constant. The 
        /// difference is that it can be assigned a value once at initialization. This
        /// allows assigning a new value at run time (through the constructor).
        /// A constant value must be assigned a value already at declaration time (hard-
        /// coded).
        /// </summary>
        /// 
        private readonly int maxAttempts;  
        private readonly int maxLevels;
        private readonly int intervalIncrement;  //milliseconds between popups
        private string playerName; 
       

        /// <summary>
        /// Variables for saving user actions.
        /// </summary>
        private int numOfTargetHits;
        private int numOfTargetPopups;  //Incremented every time target is displayed
        private int numOfAttempts;


        /// <summary>
        /// Constructor with parameters
        /// </summary>
        public CatchMe (int maxAttempts, int levels, int interval)
        {
            DefaultValues();

            this.maxAttempts = maxAttempts;
            this.maxLevels = levels;
            this.intervalIncrement = interval;
        }

        public void DefaultValues()
        {
            numOfTargetHits = 0;
            numOfTargetPopups = 0;       
            numOfAttempts = 0;
      }
#region Properties
        //set and get property connected to playerName
        public string Name
        {
            get { return playerName; }
            set
            {
                if (!string.IsNullOrEmpty ( value ))
                    playerName = value;
                else
                    playerName = "Apu";
            }
        }

        //Why not also a set property ?
        public int MaxAttempts
        {
            get { return maxAttempts; }
        }

        public int NumOfTargetHits
        {
            get { return numOfTargetHits; }
        }

        public int NumOfAttempts
        {
            get { return numOfAttempts; }
        }

        //milliseconds
        public int IntervalIncrement
        {
            get { return intervalIncrement; }
        }

        public int NumOfAttemptsLeft
        {
            get { return maxAttempts - numOfTargetPopups; }
        }


        public int MaxMilliSecond
        {
            get { return maxLevels * intervalIncrement; } //ex: 10 * 300 = 3000 milliseconds;
        }
#endregion

        //Could this be written as a 
        //set property?
        public void IncrementTargetHits()
        {
            numOfTargetHits++;
        }

        //Could this be written as a 
        //set property?
        public void IncrementTargetPopups()
        {
            numOfTargetPopups++;
        }

        //Could this be written as a 
        //set property?
        public void IncrementAttempts()
        {
            numOfAttempts++;
        }


        //Could this be written as a 
        //get property?
        public bool IsGameOver()
        {
            return (numOfTargetPopups >= maxAttempts);
        }
        /// <summary>
        /// This method calculates the interval for the timer to tick,
        /// based on the level.  Every level raises the interval by some milli-
        /// seconds.
        /// </summary>
        /// <returns></returns>
        public int GetLevelBasedInterval(int level)
        {
            int value = (level + 1) * intervalIncrement;
            return (MaxMilliSecond - value + intervalIncrement);
        }


        //What is this method good for?
        public override string ToString()
        {
            string info = string.Format("You have {0} attempts.", maxAttempts);
            info += Environment.NewLine + Environment.NewLine; //two blank lines
            info += string.Format("Every level raises the speed with {0} milliseconds.", intervalIncrement);
            return info;
        }

    }
   
 
}

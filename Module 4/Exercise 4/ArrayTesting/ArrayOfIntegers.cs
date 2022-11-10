//Array example
//Farid Naisan 2011-03-11
using System;

namespace ArrayOfOjectsTest
{
	/// <summary>
	/// Class exmining different operations on an array of integers.
	/// </summary>
	public class ArrayOfIntegers
	{
		int[] myArray;   // Declare an array
        string outputString = string.Empty;


        //Constructor - has same name as the class - no return type
        //Is used to initiate an object of this class with
        //initial values
        //The constructor here has no parameter and is called
        //a default constructor.  Compiler initiates all instance
        //variables.  Here it set myArray to null! (array not created)
        //A constructor is a good place to create objects used as 
        //fields (instance variables).  Here myArray is created.
        public ArrayOfIntegers()
		{
           //CreateArray
			myArray = new int[6];  // Allocate  6 elements of type integer
			SetTestValues();
         }

        public string GetTestResult()
        {
            outputString = "Before Resizing" + BlankLines(2);
            outputString += this.ToString();

            ResizeArray(10);
            outputString += BlankLines(3);  //insert 3 blanklines
            outputString += "After Resizing"+BlankLines(2);
            outputString += this.ToString();

            outputString += BlankLines(3);
            outputString += "Let's now put some test values in the array.";
            SetTestValues();
            outputString += this.ToString();
            return outputString;
        }

		//Put some test values
		public void SetTestValues()
		{
			for (int i = 0; i < myArray.Length; i++)
				myArray[i] = i;   // testvalues 1*1, 2*2, 3*3 ...
		}

        /// <summary>
        /// You can resize an array so it gets a new size,
        /// either larger or smaller, simply by using the keyword
        /// new on the variable again.
        /// The array will be re-created and initialized;
	    ///all existing values will be lost			
        /// </summary>
        /// <param name="newSize"></param>
		public void ResizeArray(int newSize)
		{
            myArray = new int[newSize];
		}

        //this little method returns a number of blank lines
        //A good utility
        private string BlankLines(int count)
        {
            string blankLines = String.Empty;
            for (int i = 0; i < count; i++)
                blankLines += Environment.NewLine;
            return blankLines;
        }

        //return a long list of all values separated with spaces
        //you should write the ToString method in all your classes to return 
        //a string that represents the status (data) of the object.
        //ToString otherwise returns the address of the object if you don't
        //override it!
        public override string ToString()
		{
			string strRes = String.Format("The array has {0} elements.", myArray.Length);
            strRes += Environment.NewLine; //blank line inserted

			for (int i = 0; i < myArray.Length; i++)
				strRes += String.Format("{0, 3} ", myArray[i].ToString());

			return strRes;
		}



	}
}

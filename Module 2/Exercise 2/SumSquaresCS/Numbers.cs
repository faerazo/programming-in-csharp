using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumNumbersCS
{

    //Code example methods and control statements
    //
    //Created:  By Farid Naisan 2018-09-18
    //
    //Test of void and non-void methods with parameters
    //How many iterations, counted from 0, does it take to
    //make sum of the squares go to som number (ex 200)?
    //return the sum of the squares

    //To Do: try to follow and understand the code.
    //Provide comments (xml-format)

    public class Numbers
    {
        //Instance variables (input/output for needed for the object)
        private int maxNum = 200;  //the upper limit to calculate to.
        private int numOfIterations = 0; //default value
        
        //Take the steps necessary to enable calculations and getting results.
        //In fact, this method is a type interface to other objects.
        public void Start()
        {
            //Step 1:  Get input
            maxNum = ReadMaxNum();  //read user input

            //Step 2:  Make calculations
            int count = 0;
            //Count must be an out-parameter to bring a value from the callee
            //method (CalcSumOfSquares). The callee method must also declare
            //the parameter as an out-parameter (see the method below).
            //Note: if count hade a value before this call, the value would
            //not be used in the CalcSumOfSquares.
            int sum = CalcSumOfSquares ( out count );

            //Step 3:  Display output
            ShowResults ( numOfIterations, sum ); //call to a void method
        }
        private int ReadMaxNum()
        {
            //Call the object's method to start calculation
            Console.WriteLine("Give a whole positive number (ex 500) to return the number of iterations");
            Console.WriteLine("that it takes for the sum of the squares, 1*1 + 2*2 + 3*3 . . .");
            Console.Write("to equal or exceed that number:  ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return number;
        }
        /// <summary>
        /// Iterate from 0 until the sum of the squares becomes
        /// equal to or exceeds the max value given by the user
        /// </summary>
        /// <param name="count">is an output variable that transports
        /// a value to the caller method.  It is not to be declared
        /// as a local variable, but it should be initialized (to 0)
        /// </param>
        /// <returns></returns>
        private int CalcSumOfSquares(out int count)
        {
            count = 0;  //no type decl (int count) but set to 0
            int sum = 0;  //local variable hold the result value

            while (sum < maxNum)
            {
                sum += count * count;
                count += 1;
            }

            return sum;      //result to send back to the caller
        }

        //Show the number of iterations and the sum to the console window
        //This method has access to to numOfIterations that could be 
        //used directly instead of count, but to make more general (and to
        //exercise with parameters) we let it receive both count and sum as
        //intput to the method.
        private void ShowResults(int count, int result)
        {
            Console.WriteLine();            //blank line
          
            //Prepare a result string to print out
            //Break down the code into several lines to improve readability
            string strOut = "It took " + count.ToString() + " iterations";
            strOut += " for the sum get to or exceeds " + maxNum.ToString();
            strOut += " (sum = " + result.ToString() + ")";

            //Write out the result text
            Console.WriteLine(strOut);

         }

     }
}
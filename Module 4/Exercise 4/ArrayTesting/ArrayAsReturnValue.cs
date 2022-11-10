//Array examples
//Farid Naisan
//You don't need to answer the quiz questions at this time.
//Make sure you can answer them.

using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayOfOjectsTest
{
    /// <summary>
    /// A class with a method that receives an array of 
    /// doubles and returns an array of strings 
    /// a method receiving an array
    /// </summary>
    class ArrayAsReturnValue
    {

        public string[] CalculateSquares(double[] numbers)
        {
            //check the validity of the numbers
            bool ok = CheckArray(numbers);
            //declare an array of strings with the same size as
            //the the numbers

            //Quiz question: numberString is an array of strings
            //Can you declare the same array in another way so
            //it has the same number of elements?
            string [] numberStrings = new string[numbers.Length];
            double result = 0;  //working variable

            for (int index = 0; index < numbers.Length; index++)
            {
                result = numbers[index] * numbers[index];
                numberStrings[index] = string.Format("{0,6:f2} * {0, 6:f2} = {1, 8:f2}", index, result);
            }

            //Quiz questions:  1. what difference do you think it makes if I hade 
            //declared result inside the for-loop?
            //2. Do you understand the expression: string.Format("{0,6:f2} * {0, 6:f2} = {1, 8:f2}", index, result)?
            return numberStrings;

        }
        /// <summary>
        /// Makes sure that the given array is created and it has 
        /// at least one element.
        /// </summary>
        /// <param name="numberList"></param>
        /// <returns></returns>
        public bool CheckArray(double[]  numberList)
        {
            if ((numberList == null) || (numberList.Length == 0))
                return false;
            else 
                return true;
        
        }


    }
}

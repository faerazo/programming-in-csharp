//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// Initialization.cs
// Farid Naisan, 2005 - 10 - 12
// Revised 2011-03-10
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

using System;

namespace ArrayOfOjectsTest
{
	/// <summary>
	/// Arrays can be initialized in an easy way.  Practical when 
    /// you have constant values or value tables
	/// </summary>
	public class ArrayInitialization
	{
		//Arrays below have different number of elements
        //Both arrays and elements are created automatically
        //The size should not be specified - will be done by the compiler.
		private double[] numListA = {2, 4.5, 5.5}; 
		private int[] numListB = {1, 2, 3, 4, 5, 6}; 

		//Multiply elements of array one to array 2 and sum the total
        //Muliplication is for position to position
		//
		public double MultiplyArrays()
		{
			int minSize = Math.Min(numListA.Length, numListB.Length);
			int pos;  //counter
			double sum  = 0.0;   //accumulate sum

			for (pos = 0; pos < minSize; pos++)
				sum += numListA[pos] * numListB[pos];
			
			return sum;
		}

	}//class

} //namespace

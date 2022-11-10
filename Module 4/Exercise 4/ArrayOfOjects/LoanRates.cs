//Farid Naisan
//class with static members

//Quiz questions:  
//  Why static?
//  What is the difference between .Length and .Length(1) used in the 
//  code here?

using System;

namespace ArrayOfOjectsTest
{

	public enum LoanType {HouseLoan,CarLoan, BoatLoan, OtherLoan};


	public class LoanRates
	{					
		//Rectangular array for rates with a   //1 year //2-year  //3-year  //4-year  //5-year
		//array is static-declared because there should be one common table for all
        //loans
		private static double[,] interestRates = {	
                                            {0.0298, 0.0320, 0.0340, 0.0380,  0.0420},  //House
											{0.0420, 0.0440, 0.0460, 0.0475,  0.0510},  //Car
											{0.0420, 0.0440, 0.0460, 0.0475,  0.0510},  //Boat
											{0.0520, 0.0540, 0.0560, 0.0575,  0.0610}};  //Othe
				

		/// <summary>
		/// Return the current rate for a type of loan
		/// </summary>
		/// <param name="loan">type of loan</param>
		/// <param name="year">period of loan</param>
		/// <returns>current rate from the above table.</returns>
		public static double Ränta(LoanType loan, int year)
		{
			if ( ( year <0 ) || ( year > interestRates.GetLength(0) ) )
				return -1.0;  //if control fails
			else
				return interestRates[(int)loan, year];
		}

		/// <summary>
		/// Returns the whole table. It formats one the rates for 
        /// a type of loan in a string.  The type of loans is taken
        /// from the enum
		/// </summary>
		/// <param name="tableRows">array receiving the table</param>
		public static void GetLoanInterestRates(ref string[] tableRows)
		{
			//Create a string array with as many elements as 
            //the rows in the above table
			//
			tableRows = new string [4];  
			
			//The rates in a table form
            for (int i=0; i < interestRates.GetLength(0); i++)  //rad
			{
				tableRows[i] = Enum.GetName(typeof(LoanType), i);  //Enum is ready object

				for (int j=0; j < interestRates.GetLength(1); j++) //colums
				{
					if ( (j==0) || (j==3)) //Skip years 1 and  4 (don't exist)
						continue;  
					
					tableRows[i] += String.Format("{0,15}", interestRates[i,j]);
				}
			}
		}	//GetInterest		
	}//class
}//namespace

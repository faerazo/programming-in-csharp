using System;

namespace ArrayOfOjectsTest
{
	/// <summary>
	/// class showing array of objects
	/// </summary>
	public class LoanManager
	{
		private const int maxElements = 50; //max number of elements in the array
		private BankLoan [] loanList ; //ref variable - declared but not created

        //Always two steps in creating arrays:
        //1.  Create the array (ref variable), here loanList
        //2.  Create each element of the array here BankLoan
        //A good place to create objects is inside the constructors
		public  LoanManager()
		{

            //Create array - elements are created later
            loanList = new BankLoan[maxElements - 1];
            FillListWithTestValues();
		}
        //Only for testing 
        //Note that each element in the array is created using 
        //the keyword new
        private void FillListWithTestValues()
        {
            string defaultName;
            decimal startBalance;

            for (int i = 0; i < loanList.Length; i++)
            {
                defaultName = "Untitled" + i.ToString();
                startBalance = Convert.ToDecimal(i + 100.0); //Testvalues = (counter + 100) kr
                loanList[i] = new BankLoan(defaultName, startBalance);     //element[i] created
            }
        }


		//Method to sum up balance amount of all accounts
		public decimal SumBalanceForAllAccounts()
		{
			decimal sum = 0m;  //variable to accumulate the sum
			for (int i = 0; i < loanList.Length; i++)
				sum += loanList[i].Balance;
	            
			return sum;
		}
	
		//Search for a customer - return the first occurance
		public int FindCustomer(string name) 
		{
			bool found = false;
			int i = 0;
					
			do
			{  //.CustomerName is a property - called with no 
                //parenthesis,  CustomerName() - wrong
				if (loanList[i].CustomerName == name)
					found = true;
				else
					i++;  //go to next

			}while ((!found) && (i < loanList.Length));

            //return i if found and -1 if not found
			return (found ? i : -1);
		}
	}

}

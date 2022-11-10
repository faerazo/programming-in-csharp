
//Farid Naisan 
//used for testing of arrays

using System;

namespace ArrayOfOjectsTest
{

	/// <summary>
	/// A simple BankLoan class
	/// </summary>
	public class BankLoan
	{
		private decimal balance; 
		private string customerName;  //account owner

		//Constructor - same name as the class - no return type
        //Is used to initiate an object of this class with
        //initial values for the balance and the name of the 
        //customer.  So, whenever you create an object of this class
        //you can pass inital values as:
        //BankLoan loan = new BankLoan("Nisse, 2500m) m needed for 
        //decimal types
		public BankLoan(string name, decimal balance)
		{
			//2ith the keyword, this, the object references itself.
			this.customerName = name;
			this.balance = balance;
		}

		//Property to return balance
        //The property can be called in this way:
        // BankLoan  bankLoanObj = new BankLoan()
        // decimal amount = bankLoanObj.Balance
        //no parenthesis i method call  
		public decimal Balance
		{
            get { return balance; }    //readonly property
		}
        //Property to return customerName
        //The property can be called in this way:
        // BankLoan  bankLoanObj = new BankLoan()
        // string name = bankLoanObj.CustomerName
        //no parenthesis i method call  
				
		public string CustomerName
		{
			get{ return customerName; }    //readonly property
		}
	}//class
}

//Code example - arrays
//Farid Naisan 2011-03-10

//TO DO:  Try to understand the code.  Write xml-compatible comments to all 
//classes and methods of the classes.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArrayOfOjectsTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            string message = "The code files contain a number of quiz questions.";
            message += "You don't have to answer them now, , but make sure you know the answer";
            message += " as they may appear as question in the next quiz in the module.";
            lblMessage.Text = message;

        }

      //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void btnArrayOfObjects_Click(object sender, EventArgs e)
        {
            LoanManager loanManager = new LoanManager();

            decimal sumOfAllBalances = loanManager.SumBalanceForAllAccounts();
            MessageBox.Show(String.Format("Sum of all accounts: {0:C}", sumOfAllBalances),
                                        "Array of objects");

            string[] interestTable = null; //created and sized in the method that is called below

            //arrays are always passed by reference
            //Quiz question:  what does ref mean here then?
            LoanRates.GetLoanInterestRates(ref interestTable);

            string strRes = String.Format("{0, 10} {1, 15} {2, 15} {3, 15}{4}",
                "1-year loan", "2-year loan", "3-year loan", "5-year loan", Environment.NewLine);

            for (int i = 0; i < interestTable.Length; i++)
                strRes += interestTable[i] + Environment.NewLine;

            MessageBox.Show(strRes, "See LoanRates class");

        }
  
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void btnForEach_Click(object sender, EventArgs e)
        {
           TestOfForEach testObj = new TestOfForEach();
            MessageBox.Show("Sum: " + testObj.Test().ToString(), "Testing foreach");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit, are you sure?", "MessageBox example", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //to close this window write:  this.Close()
                //To exit the application and close all windows,
                //use Application.Exit()
                Application.Exit();
            }

        }

    }
}

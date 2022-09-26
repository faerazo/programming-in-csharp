//Code example
//Farid Naisan, 2012, revised mars 2014

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PensionCalculatorV1
{
    /// This class is solely responsible for all user interactions.
    /// Everything that has to to with GUI is placed here.
    /// BUT it uses other objects to do other jobs. In this example
    /// project, it uses an object of the class Pension

    public partial class MainForm : Form
    {
        //instance variable 
        private Pension pensioner; //an object of Pension

        /// This method is called a constructor
        /// It has (1) same name as the class (MainForm) and 
        /// (2) it has no return type - not even void.
        /// Partial is a keyword that allows the code to class to be 
        /// placed and saved in more than one file.
        public MainForm()
        {
            //VSs initialization
            InitializeComponent();

            //My initializations
            InitializeGUI();
        }

        /// <summary>
        /// Do all the initiatlizations here.  When this method is called
        /// the form should be clear of input/output data and other controls
        /// should be initialized
        /// </summary>
        private void InitializeGUI()
        {
            pensioner = new Pension();
            lblPensionSalary.Text = " -  ";
            lblPensionYear.Text = " -  ";
        }

        /// <summary>
        /// Event-handler method connected to the button. 
        /// This method is executed automatically when the button is 
        /// clicked at run-time.
        /// </summary>
        /// <param name="sender">The object firing the event.</param>
        /// <param name="e">contains information about the event.</param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //if ReadInput is done successfully, ok will be true
            bool ok = ReadInput();

            //Continue only if the input process is successful.

            if (ok)
            {
                UpdateGUI();
            }
            else
            {
                MessageBox.Show("Invalid input!");
                //return;   //cancel rest of execution (if you have more code after this block.
            }

          }
        
        /// <summary>
        /// Read the user's values, name, age and monthly income, from the GUI. 
        /// Save the values in an object of Pension (declared as a field to this class.)
        /// </summary>
        /// <returns>true if reading of input goes without error, and false otherwise.</returns>
        private bool ReadInput()
        {
            //Local variable to temporaily save the input;
            //you can actually use the pensioner object instead.
            //The purpose here is to make the code more readable for you.

            string name = txtNamn.Text.Trim();  //trim beginning and trailing spaces
            int age = 0; 
            double monthlyPay = 0.0;
            
            //name should not be empty
            bool ok = !string.IsNullOrEmpty(name);
            
            //ok from the control of name can be true/false 
            //if true tryParse must also be true for both age and monthlyPay
            //out- says that the variable age (and monthlyPay) are output variables
            //intended to receive the converted value.  If TryParse fails, the variable
            //is set to zero.  Control of the value of ok is important!
            ok = ok && int.TryParse(txtAge.Text, out age);
            ok = ok && double.TryParse(txtMonthlyPay.Text, out monthlyPay);

            if (ok)
            {
                //Call the setter methods to send the input to
                //pension object, pensioner
                pensioner.SetName(name);
                pensioner.SetAge(age);
                pensioner.SetMonthlyIncome(monthlyPay);            
            }
            return ok;
        }

        //Keep the screen updated whenever data changes in the application.
        private void UpdateGUI()
        {
            grpUtdata.Text = pensioner.GetName().ToUpper();
            lblPensionYear.Text = pensioner.CalcPensionYear().ToString();
            lblPensionSalary.Text = pensioner.CalcMonthlyPensionIncome().ToString("00");
        }
    }
}
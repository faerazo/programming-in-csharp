//Code example - arrays
//Farid Naisan 2011-03-10

//TO DO:  Understand the code and write XML-compatible comments to classes and
//        methods of the classes.
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
            InitializeComponent(); //Windows initialization
            InitializeGUI();  //The programmer's (my) initialization
        }
        private void InitializeGUI()
        {
            string message = "The code files contain a number of quiz questions.";
            message += "You don't have to answer them now, , but make sure you know the answer";
            message += " as they may appear as question in the next quiz in the module.";
            lblMessage.Text = message;

        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void btnInit_Click(object sender, EventArgs e)
        {
            ArrayInitialization testObj = new ArrayInitialization();
            double sum = testObj.MultiplyArrays();
            MessageBox.Show("Sum of mulitplication = " + sum.ToString("0.0"), "Array Test");
        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void btnArrayOfIntegers_Click(object sender, EventArgs e)
        {
            ArrayOfIntegers arrayObj = new ArrayOfIntegers();
            MessageBox.Show(arrayObj.GetTestResult(), "Resizing arrays");

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

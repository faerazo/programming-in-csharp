//Code Example:
//Created by Farid Naisan, Jan 2012

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComboBoxEx
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //Windows initialization
            InitializeComponent();
           
            //My initializations

            InitializeGUI();
        }
        private void InitializeGUI()
        {
            //Fill the combobox with valeus from the 
            //DisplayOptions enum
            //Enum.GetNames retrieves an array of strings of the values of the
            //enum members. The ComboBox's Addrange method requires an array of
            //strings
            cmbDisplayOptions.Items.AddRange(Enum.GetNames(typeof(DisplayOptions)));

            //Set an option as the default option so the combo box does not look 
            //empty at programstart.
            cmbDisplayOptions.SelectedIndex = (int)DisplayOptions.LongDateTimeFormat;

                   //Give some info on the gui
            lblInfo.Text = "Choose a date to count down.  The time will be counted from this moment";

            lblResult.Text = String.Empty;
        }

        private void Calculate()
        {
            CountDown timeObj = new CountDown(dateTimePicker1.Value);
            DisplayOptions option = (DisplayOptions)cmbDisplayOptions.SelectedIndex;
            lblResult.Text = timeObj.CalcDateTimeLeft(option);           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        
    }
}

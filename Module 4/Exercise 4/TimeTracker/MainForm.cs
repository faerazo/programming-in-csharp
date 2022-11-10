//Code Example - Farid Naisan
//Created:  2014-10-10 by Farid Naisan


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeTracker
{
    /// <summary>
    /// When the program starts, the current month and current day are
    /// to be default values.  The schedule should appear with zero values
    /// from the array saved in the m_schedule
    /// </summary>
    public partial class MainForm : Form
    {
        //Create a schedule
        Schedule m_schedule = new Schedule();

        /// <summary>
        /// MainForm constructor.  Do all your initialization here
        /// after InitializeComponent - which is Visual Studio's 
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            //My initialization
            InitializeGUI();
        }

        /// <summary>
        /// Initialize input/output controls, fill in comboboxes, etc.
        /// </summary>
        private void InitializeGUI()
        {
            //Fill the days-combobox with initial data (days of the current month)
            UpdateDaysOfTheMonth(); 
                       
            //Fill the months of the year into its combobox
            cmbMonths.Items.AddRange(Enum.GetNames(typeof(MonthsOfYear)));
            //Choose a default month (current month)
            cmbMonths.SelectedIndex = m_schedule.Month-1;

            UpdateGUI();
        }

        /// <summary>
        /// Fill the day-comobox with day number 01 to numofdays in the month.
        /// Set the selected day as the option
        /// </summary>
        private void UpdateDaysOfTheMonth()
        {
            cmbDays.Items.Clear();
            int days = m_schedule.MonthDays;

            for (int i = 0; i < days; i++)
            {
                cmbDays.Items.Add((i + 1).ToString("00"));
            }
            //Choose a default option for day
            cmbDays.SelectedIndex = m_schedule.Day - 1;

        }

        /// <summary>
        /// Add the hours entered by the user to the time-tracker array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AddNewValue())
            {
                UpdateGUI();
            }
        }

        /// <summary>
        /// Save the hours that the user enters in a textbox on the GUI
        /// for the selected month and day. 
        /// </summary>
        /// <returns></returns>
        private bool AddNewValue()
        {
            bool ok = true;

            //Read and validate month and day
            if (!ReadAndUpdateDateInfo())
                return false;

            //Read hours
            double hours = 0;

            txtHours.ForeColor = Color.DarkGreen;

            if (Double.TryParse(txtHours.Text, out hours))
            {
                //save in the m_schedule object
                 m_schedule.AddNewValueInTable(hours);               
            }
            else
            {
                ok = false;
                txtHours.ForeColor = Color.Red;
                txtHours.Focus();
                if (String.IsNullOrEmpty(txtHours.Text))
                    txtHours.Text = "????";  //to get highlited
                txtHours.SelectAll();
                MessageBox.Show("Invalid number of hours");
            }
            return ok;
        }

        //Refresh the table on the GUI. 
        private void UpdateGUI()
        {
            lstResults.Items.Clear();
            lstResults.Items.AddRange(m_schedule.GetAllTableRowsAsStringArray());
            lblSum.Text = m_schedule.GetSumOfHoursForMonth().ToString("0.0");
        }
        

        /// <summary>
        /// Event-handler method connected to month-combobox, selection change.
        /// Read the selection and adjust the number of days for the selected
        /// month.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadAndUpdateDateInfo();
            UpdateDaysOfTheMonth();
            UpdateGUI();
        }
        /// <summary>
        /// Read month, day and save in the m_schedule
        /// </summary>
        /// <returns></returns>
        private bool ReadAndUpdateDateInfo()
        {
            int month = cmbMonths.SelectedIndex;
            int day = cmbDays.SelectedIndex;

            if ((month < 0) || (day < 0))
                return false;

            m_schedule.Day = day + 1;  //to count from 1
            m_schedule.Month = month+1;  //to count from 1

             return true;
        }

    }
}

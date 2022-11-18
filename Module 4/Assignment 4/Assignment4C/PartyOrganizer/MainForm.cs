using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyOrganizer
{
    public partial class MainForm : Form
    {
        // reference variable declared 
        PartyManager partyManager;

        public MainForm()
        {
            InitializeComponent();
            // call method to prepare GUI
            InitializeGUI();
        }


        private void InitializeGUI()
        {
            this.Text = "Party Organizer by Francisco Erazo";

            // input controls for new party
            textBoxMaxGuests.Text = string.Empty; // textbox for max number guests is declared empty
            textBoxCostPerson.Text = string.Empty; // textbox for cost per person is declared empty
            textBoxFeePerson.Text = string.Empty; // textbox for fee per person is declared empty
            textBoxFirstName.Text = string.Empty; // textbox for first name is declared empty
            textBoxLastName.Text = string.Empty; // textbox for last name is declared empty

            // group boxes
            groupBoxParty.Enabled = true; // enable group box for new party
            groupBoxGuest.Enabled = false; // disable the groupbox for adding new guests

            // output results
            labelNumberGuestsResult.Text = ""; // label for the number of guest result is declared empty
            labelTotalCostResult.Text = ""; // label for total cost result is declared empty
            labelTotalFeesResult.Text = ""; // label for total fees result is declared empty
            labelSurplusResult.Text = ""; // label for surplus or deficit result is declared empty
            listBoxList.Items.Clear();
        }

        private void buttonCreateList_Click(object sender, EventArgs e)
        {
            bool inputOK = ReadInputNewParty();

            //if (inputOK) { }
        }


        private bool ReadInputNewParty()
        {
            bool maxNumberGuestsOK = ReadMaxNumberofGuests();
            bool costPersonOK = ReadCostPerPerson();
            bool feepersonOK = ReadFeePerPerson();

            return maxNumberGuestsOK && costPersonOK && feepersonOK;
        }


        private bool ReadMaxNumberofGuests()
        {
            bool valueOk = false;
            int value = 0;
            string strValue = textBoxMaxGuests.Text.Trim();

            valueOk = int.TryParse(strValue, out value);
            if (!valueOk)
            {
                MessageBox.Show("Invalid input for maximum number of guests!", "Error");
            }
            // here set the maxnumber of guets
            return valueOk;
        }


        private bool ReadCostPerPerson()
        {
            bool valueOk = false;
            double value = 0.0;
            string strValue = textBoxCostPerson.Text.Trim();

            valueOk = double.TryParse(strValue, out value);
            if (!valueOk)
            {
                MessageBox.Show("Invalid input for cost per person!", "Error");
            }
            // here set the cost per person
            return valueOk;
        }


        private bool ReadFeePerPerson()
        {
            bool valueOk = false;
            double value = 0.0;
            string strValue = textBoxFeePerson.Text.Trim();

            valueOk = double.TryParse(strValue, out value);
            if (!valueOk)
            {
                MessageBox.Show("Invalid input for fee per person!", "Error");
            }
            // here set the cost per person
            return valueOk;
        }


    }
}

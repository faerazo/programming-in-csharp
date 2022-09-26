//Code example
//Farid Naisan, 2014-03-05

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBoxProgram
{
    public partial class MainForm : Form
    {
        //instansvariables
        private int numOfItems = 5;  //for tsting

        //This class is using an object of the Product class
        private Product product = new Product();

        //A format that will be used for displaying data in 
        //the listbox.
        private string format = "{0,3:d} {1}"; //0: index in the list, 1: product.ToString

        //Constructor, do all your initializations here.
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
 
        //Method that inializes the controls on the GUI
        private void InitializeGUI()
        {
            lstOutput.Items.Clear();

            for (int i = 0; i < numOfItems; i++)
                lstOutput.Items.Add(string.Format(format,i, product.ToString()));

            lblCount.Text = string.Empty;
            lblSelected.Text = string.Empty;
        }

        //Event-handler method- invokes automatically when an item is hightlighted
        //in the listBox
        private void lstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        //Event-handler method- invokes when the Add-button is clicked. 
        //The data for a new product is added to the end of the listbox.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Validation can be done when reading data from GUI
            //or can be later after they have been saved in variables.

            bool ok = ReadAndValidateInput();
            if (ok)
            {
                int index = lstOutput.Items.Count; //last item+1
                string textOut = string.Format(format, index, product.ToString());
                lstOutput.Items.Add(textOut);//append to the end of the list
                UpdateGUI();
            }
        }

        //Read the values from the GUI controls and save
        //in the dedicated variables
        private bool ReadAndValidateInput()
        {
            product.SetName(txtName.Text);
            double price = ReadPrice();
            product.SetPrice(price);
            
            string errMessage = string.Empty;

            if (!product.ValidateData(out errMessage))
            {
                MessageBox.Show(errMessage, "Error");
                return false;
            }

            return true;
        }

        //If an item is highlighted in the listbox, the index of the 
        //selected item is saved in the listbox's SelectedIndex property.
        //If no line is highlighted, a value of -1 is assigned to 
        //the SelectedIndex. It is very important to check so the value
        //of the SelectedIndex is not -1 when working with the listbox.
        private int GetListBoxIndex(bool giveMessage = true)
        {
            int index = lstOutput.SelectedIndex; //-1 if not selected

            if (index < 0)
            {
                MessageBox.Show("Select an item first!", "Error");
            }
            return index;
        }

        //Read the price for the product and check that the user input
        //valid, i.e. representing a number.
        private double ReadPrice()
        {
            bool ok = false;
            double price = 0.0;
           
            ok = double.TryParse(textBox2.Text, out price);

            return price;
        }

        //Event-handler method - invokes automatically when the 
        //button btnDelete is clicked.  The item selected by the 
        //user is removed from the list.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = GetListBoxIndex();

            if (index >= 0)
            {
                lstOutput.Items.RemoveAt(index);
            }

        }

        //Event-handler method - invokes automatically when the 
        //button btnChange is clickedsa ved in the highlighted 
        private void btnChange_Click(object sender, EventArgs e)
        {
            //Validation can be done when reading data from GUI
            //or can be later after they have been saved in variables.
            bool ok = ReadAndValidateInput();
            if (ok)
            {
                int index = GetListBoxIndex(); //-1 if not selected

                if (index < 0)
                    return;
                //The value of item nr index is changed by the string formatted with
                //the index and the info from the product object.
                lstOutput.Items[index] = string.Format(format, index, product.ToString());
                UpdateGUI();
            }

        }

        //A method that updates the changes of values on the GUI.
        //Can be called from different methods.
        private void UpdateGUI()
        {
            lblCount.Text = lstOutput.Items.Count.ToString();
            lblSelected.Text = lstOutput.SelectedIndex.ToString();
        }

        //Event-handler method - invokes automatically when the Reset 
        //button is clicked.  Everything is reset including the value of 
        //the product object.
        private void btnReset_Click(object sender, EventArgs e)
        {
            product.DefaultValues();
            InitializeGUI();
            UpdateGUI();
        }

     }
}

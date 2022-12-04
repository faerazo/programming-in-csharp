//Code Example
//Created:  2008 by Farid Naisan
//Revised:  2012-12-12, ported to VS 2012

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ProductRegistryCS
{
    public partial class MainForm : Form
    {
        //instance variables
        private ProductManager productMngr;
       
 
        //Default constructor
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        public ProductManager ProductManager
        {
            get => default ( ProductManager );
            set
            {
            }
        }

        private void InitializeGUI()
        {
            productMngr = new ProductManager();
        }

      
         
        //Everytime changes in the registry occur, update the GUI.
        //For the list of products, clear the contents and refill  
        //the list with current values saved in the registry. 
        void UpdateGUI()
        {
            lstProducts.Items.Clear();

            for (int i = 0; i < productMngr.Count; i++)
            {
                lstProducts.Items.Add(productMngr.GetProduct(i).ToString());
            }
            lblSum.Text = String.Format("{0:C}", productMngr.TotalSum);
            lblItems.Text = productMngr.Count.ToString();
        }
        
        //Read the data from the GUI and save in a local
        //object of the type Product.  Send the object to be
        //added to the registry in the m_ProductMngr
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = ReadInput();

            if (product != null)
            {
                productMngr.AddProduct(product);
                UpdateGUI();
                            }
            else
                MessageBox.Show("Invalid input!");
        }

        //Read data from the GUI and save it in a local
        //object of Product class.  Return the object.
        private Product ReadInput()
        {
            double price = 0.0;
            int quantity = 0;
            bool priceOk = double.TryParse ( txtPrice.Text, out price );
            bool quantityOK = int.TryParse ( txtNumber.Text, out quantity );
            bool nameOK = !txtName.Text.Equals ( String.Empty );

            if (priceOk && quantityOK && nameOK)
            {
                Product product = new Product(txtName.Text, price, quantity);
                return product;
            }
            else
                return null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = lstProducts.SelectedIndex;
            if (index >= 0)
            {
                Product product = ReadInput();

                if (product != null)
                {
                    if (productMngr.ChangeProduct(product, index))
                        UpdateGUI();
                    else
                        MessageBox.Show("Edit unsuccessful!");
                }
            }
		

        }
        //If an item is selected in the productlist, ask the 
        //m_productMngr to remove the corresponding object from
        //its regisgry
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstProducts.SelectedIndex;
            if (index >= 0)
            {
                productMngr.DeleteProduct(index);
                UpdateGUI();
            }
        }

        //This method is automatically executed whenever the user clicks
        //on an item in the listbox.
        //The index of the selected item is used to ask the m_productMngr
        //to get the corresponding object from its registry.
        //Fill the input boxes on the GUI with information from the 
        //product object.
        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstProducts.SelectedIndex;
            if (index >= 0)
            {
                Product prod = productMngr.GetProduct(index);
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();
                txtNumber.Text = prod.Count.ToString();
            }

        }

           
    }
}

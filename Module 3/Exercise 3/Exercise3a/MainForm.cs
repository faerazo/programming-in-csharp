using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3a
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            if (string.IsNullOrEmpty(name))
                MessageBox.Show("Please give your name!");
            else
            {
                //Conver name to uppercase
                name = name.ToUpper();
                //Display name in the dedicated label
                lblOutput.Text = name;
            }

        }
    }
}

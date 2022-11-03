using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class MainForm : Form
    {
       private CurrencyExchange converter = new CurrencyExchange ( );

        public MainForm ( )
        {
            InitializeComponent ( );
            InitializeGUI ( );
            //converter = new CurrencyExchange ( );
        }

        

        private void InitializeGUI()
        {
            lblResult.Text = string.Empty;
            lblResult.ForeColor = Color.DarkGreen;
            this.Text = "Currency Converter";
            
        }


        //Event-handler method connected the Click-event of 
        //the btnOK (convert button)
        private void btnOK_Click (object sender, EventArgs e)
        {
            //Read input - call 
            //1. Write a main ReadInput method
            bool ok = ReadInput ( );

            if (ok)
            {
                double convertedAmount = converter.CalculateNewAmount ( );
                lblResult.Text = convertedAmount.ToString ( "0.00" );
            }
           
            
        }

       
       private bool ReadInput()
       {
            //the amount
            bool amountOK = ReadAmount ( );
            //the exchange rate
            bool rateOK = ReadExchangeRate ( );

            return amountOK && rateOK;
       }
        
       /// <summary>
       /// This reads the contents of the textbo txtAmount
       /// and converts the string to its correspondent numerical value.
       /// </summary>
       /// <returns>true if the conversion is successful, false otherwise</returns>
       private bool ReadAmount()
        {
            bool ok = true;
            string strAmount = txtAmount.Text;
            strAmount = strAmount.Trim ( );
            double amount = 0.0;

            ok = double.TryParse ( strAmount, out amount );
            if (ok)
                converter.SetAmountToExchange ( amount );
            else
                MessageBox.Show ( "Invalid amount!", "Error" );
            
            return ok;
        }

        private bool ReadExchangeRate ( )
        {
            bool ok = true;
            string strRate = txtRate.Text;
            strRate = strRate.Trim ( );
            double amount = 0.0;

            ok = double.TryParse ( strRate, out amount );
            if (ok)
                converter.SetExchangeRate ( amount );
            else
                MessageBox.Show ( "Invalid exchange rate!", "Error" );

            return ok;
        }
    }
}

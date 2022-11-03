using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class CurrencyExchange
    {
        private string fromCurrencyName;
        private string toCurrencyName;

        private double exchangeRate; //1 from = x to
        private double amountToExchange;

       

        #region Setter and getters
        public string GetFromCurrencyName()
        {
            return fromCurrencyName;
        }
        public void SetFromCurrencyName(string name)
        {
            if (string.IsNullOrEmpty ( name ))
                fromCurrencyName = name;
        }

        public string GetToCurrencyName ( )
        {
            return toCurrencyName;
        }
        public void SetToCurrencyName (string name)
        {
            if (string.IsNullOrEmpty ( name ))
                toCurrencyName = name;
        }
        #endregion

        public double GetExchangeRate ( )
        {
            return exchangeRate;
        }
        public double GetAmountToExchange()
        {
            return amountToExchange;
        }
        public void SetAmountToExchange(double amount)
        {
            if (amount > 0.0)
                amountToExchange = amount;
        }


        public void SetExchangeRate (double rate)
        {
            if (rate > 0.0)
                exchangeRate = rate;
        }
        /// <summary>
        /// Converts the amountToExchange to the new currency
        /// </summary>
        /// <returns>the converted amount.</returns>
        public double CalculateNewAmount()
        {
            double amount = 0.0; 
            //Check division by zero
            if (exchangeRate > 0.0)
                amount = amountToExchange / exchangeRate;

            return amount;
        }

    }
}

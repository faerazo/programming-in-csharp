//Code Example:
//Created by Farid Naisan, Jan 2012

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayOfOjectsTest
{
    class TestOfForEach
    {
        //Create an array two BankLoan objects with test
        //values
        BankLoan[] loans = {new BankLoan("Apu", 250000m),
                            new BankLoan("Nanna", 225000m)};


        //Default Constructor - Quiz:  What is it?
        //
        public TestOfForEach()
        {
           
        }

        /// <summary>
        /// With foreach you can loop through an array or collectdion
        /// and retrieve the whole object.
        /// </summary>
        /// <returns></returns>
        public decimal Test()
        {
            decimal sum = 0.0m;

            foreach (BankLoan loan in loans) 
                sum += loan.Balance;
            return sum;

        }

        /// <summary>
        /// For each is very useful with array of objects
        /// although you can use on array of primitive 
        /// types as well (as in the code below).
        /// An ordinary for-loop is more effective when
        /// working with primitive typs such as int and double.
        /// Note that foreach is always used together with the
        /// the keyword "in".
        /// </summary>
        /// <returns></returns>
        public string GetSumOfBalances()
        {
            int[] talLista = { 1, 2, 3, 4, 5 };

            string strText = "";
            foreach (int elem in talLista)
                strText += elem.ToString() + " ";

            return strText;
        } 
    }
}

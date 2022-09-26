//Code Example
//Farid Naisan, 2012, revised mars 2014
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PensionCalculatorV1
{
    /// <summary>
    /// This class calculates stores data for estimating the
    /// monthly amount a retired will received based the 
    /// current montly income and a reduction in percent.
    /// </summary>
    public class Pension
    {
        private string name;  //first name, last name
        private double monthlyIncome;
        private int age;

        private const int pensionAge = 65;  //retiremente year
        private const double reductionPercent = 40.00; //in percent

        public Pension()
        {
            name = string.Empty;
            monthlyIncome = 0.0;
            age = 0;
        }

        /// <summary>
        /// Getter method related to the field name. This method
        /// allows other objects to get the value of the private 
        /// field name.
        /// </summary>
        /// <returns>the values stored in the field name</returns>
        /// <remarks> The method needs no input from the caller. </remarks>
        public string GetName()
        {
  
        if (string.IsNullOrEmpty(name))
            return "The unknown!";
        else
            return name;
        }

        /// <summary>
        /// Setter method related to the private field name. This 
        /// method allows other objects to store a new value in the
        /// field but under controlled conditions. The method checks
        /// so the new value is a valid value and if not, it simply
        /// ignores the call, avoiding unwanted changes.
        /// </summary>
        /// <param name="name">the new value to be stored in the field</param>
        /// <remarks>This method needs an input parameter to receive the 
        /// argument. It does not need to return any value and therefore it
        /// is declared as void.</remarks>
        public void SetName(string name) 
        {
        if (!string.IsNullOrEmpty(name))
            this. name = name; 
        }

        //----------------------------------------------------------------
        //Setter and getter connected to age
        public void SetAge(int age)
        {
            //age should not be negative
            if (age >= 0)
             this.age = age;
        }

        public int GetAge()
        {
            return age;
        }

        //----------------------------------------------------------------
        //Setter and getter connected to monthly income
        public void SetMonthlyIncome(double income )
        {
            //income should not be negative
            if (income >= 0.0)
               monthlyIncome = income;  //why no "this." is used here?
        }

        public double GetMonthlyIncome()
        {
            return monthlyIncome;
        }
        //----------------------------------------------------------------


        /// <summary>
        /// Calculate the age at which one goes on pension.
        /// Calculation is based on the official pension age
        /// as defined above.
        /// </summary>
        /// <returns>the pension year.</returns>
        public int CalcPensionYear()
        {
            int currYear = DateTime.Now.Year;
            int pensionsYear = currYear + pensionAge - age;
            return pensionsYear;
        }

        /// <summary>
        /// Calculate the monthly income one will get after applying
        /// the reduction, defined above.
        /// </summary>
        /// <returns>the montly income to expect at retired age.</returns>
        public double CalcMonthlyPensionIncome()
        {
            double reduction = monthlyIncome * reductionPercent / 100.0;
            double monthlyAmount = monthlyIncome - reduction;
            return monthlyAmount;
        }
     } //end class
} //end namespace

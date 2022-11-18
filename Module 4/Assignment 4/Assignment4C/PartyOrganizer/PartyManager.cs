using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace PartyOrganizer
{
    internal class PartyManager
    {
        // instance variables
        private double costPerPerson;
        private double feePerPerson;
        
        // array for the guest
        private string[] guestList = { };

        /// <summary>
        /// constructor for the array, it uses the max number of guests to determine the size of the array
        /// </summary>
        /// <param name="maxGuests"> the maximum number of guests</param>
        public PartyManager (int maxGuests)
        {
            guestList = new string[maxGuests]; //constructed array
        }

        #region setters and getters
        // setter and getter for cost per person
        public double CostPerPerson
        {
            set
            {
                if (value >= 0.0)
                    costPerPerson = value;
            }
            get
            {
                return costPerPerson;
            }
        }


        // stter and getter for fee per person
        public double FeePerPerson
        {
            set
            {
                if (value >= 0.0)
                    feePerPerson = value;
            }
            get
            {
                return feePerPerson;
            }
        }

        #endregion

        private int NumOfGuests()
        {
            int numGuests = 0;
            
            for (int i = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    numGuests++;
                }
            }
            return numGuests;
        }

    }


}

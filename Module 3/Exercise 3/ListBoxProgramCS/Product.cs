
//Code example
//Farid Naisan, 2014-03-05

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListBoxProgram
{
    /// <summary>
    /// This class handles products defined by a product name and a price.
    /// You can put more data data types to the class.
    /// The fields are declared as private according to the OOP principles.
    /// To give access to the values, setter and getter methods are used in
    /// this class.
    /// </summary>
    public class Product
    {
        //Fields of the class
        private string name;
        private double price;

        //Default constructor - a convenient place to do initializations
        public Product()
        {
            DefaultValues();
        }

        //Set default values to this object.
        public void DefaultValues()
        {
            name = "No name";
            price = 0.0;
        }

        //Getter method to give other objects access to the value of 
        //the field name. The method has the same return type as the
        //name field.
        public string GetName()
        {
            return name;
        }

        //Setter method that allows other objects to change (overwrite)
        //the value of the name field.  This is done under controllded 
        //conditions. The value is validated before the value is accepted.
        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
                this.name = name;
        }

        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(double price)
        {
            if (price >= 0.0)
                this.price = price;
        }


        //This method vaidates the fiels.  Although the fields
        //are checked when the setter methods are called, it is
        //still a useful method.  Controls of the values in the
        //object is done by the object!!
        public bool ValidateData(out string message)
        {
            message = string.Empty;

            bool ok = (!string.IsNullOrEmpty(name)) && (price > 0.0);
            if (!ok)
                message = "Invalid input";

            return ok;          
        }

        //Return a string presentation of the values saved in the object.
        public override string ToString()
        {
            string textOut = string.Format("{0, -20}{1, 12:f2}", name, price);
            return textOut;
        }

    }
}

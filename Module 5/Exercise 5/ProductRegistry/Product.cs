
//Code Example


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductRegistryCS
{
    [Serializable]
    public class Product
    {
        private string id;     //id - should be sett by the program (ProductManager)
        private string name;   //name of a product != empty
        private double price;  //price, >= 0.0
        private int count;     //Quantity of this product >=0
        private DateTime purchaseDate;  //Date of registration

        //default constructor, needed when Product is a member in another class
        public Product() { }

        //Constructor with parameters
        public Product(string name, double price, int number)
        {
            this.id = string.Empty;
            this.name = name;
            this.price = price;
            this.count = number;
            this.purchaseDate = DateTime.Now;
        }

        
        //Copy Constructor - clone the other product
        //this poroduct is created with the same values from another Product object
        public Product(Product other)
        {
            this.id = other.id;
            this.name = other.name;
            this.price = other.price;
            this.count = other.count;
            this.purchaseDate = other.purchaseDate;
        }


        //Get and set properties
        public string ID
        {
            get { return id; }
            set
            {
                if (value != String.Empty)
                    id = value;
            }
        }
        //---------------------------------------------------
        //Properties
        public string Name
        {
            get { return name; }
            set
            {
                if (value != String.Empty)
                    name = value;
            }
        }
        public int Count
        {
            get { return count; }
            set
            {
                if (value >= 0)
                    count = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0.0)
                {
                    price = value;
                }
            }
        }

        //returns price times the number
        public double TotalValue
        {
            get { return price * count; }
        }

        //Validate product data
        public bool CheckData()
        {
            return ((!name.Equals(String.Empty)) && (price >= 0.0) && (count >= 0));
        }

        //{5,6} = variable no. 5 (counted from 0) to be right-adjusted within 6 chars
        public override string ToString()
        {

            return String.Format("{0,9} {5, 6} {1,-33} {2,8} {3, 10:f2}  {4,12:f2} ",
                purchaseDate.ToShortDateString(), name, count, price, TotalValue, id);

        }
    }
}

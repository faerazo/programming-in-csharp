//ProductManager.cs

using System;
using System.Collections;
using System.Collections.Generic;  // for List<T>
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;  //File
using System.Runtime.Serialization.Formatters.Binary;  //File

namespace ProductRegistryCS
{
    [Serializable]
    public partial class ProductManager
    {
        private List<Product> productRegistry;

        //Constructor

        public ProductManager ( )
        {
            productRegistry = new List<Product> ( );
        }

        /// <summary>
        /// Returns  a copy of an element at the position = index
        /// The copy constructor of the Product class is called to return 
        /// a copy of the object.  In this case, any changes to the copy
        /// will not affect the object in the m_productRegistry
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <remarks>return m_productRegistry[index] returns the reference of the element.
        /// returning a copy is safer</remarks>
        public Product GetProduct (int index)
        {
            //return m_productRegistry[index];  //not safe any changes to the object will affect the reg.
            Product copyObj = new Product ( productRegistry[index] );  //copying is done in the Product class
            return copyObj;

        }

        //Property for the number
        public int Count
        {
            get { return productRegistry.Count; }
        }

        //Info about an object from the list
        public string GetInfoString (int index)
        {
            return GetProduct ( index ).ToString ( );
        }

        //Add a new object to the list
        public int AddProduct (string name, double price, int number)
        {
             Product product = new Product ( name, price, number );
            product.ID = SetNewID ( );
            productRegistry.Add ( product );
            return productRegistry.Count - 1;
        }

        //Add a new object to the list - overloaded function
        public int AddProduct (Product prod)
        {
            if (prod != null)
            {
                prod.ID = SetNewID ( );
                productRegistry.Add ( prod );
            }
            return productRegistry.Count - 1;
        }
        private string SetNewID ( )
        {
            const string startID = "PR";
            return startID + Count.ToString ( );
        }
        //Change the values of the object at the position=index in the list
        public bool ChangeProduct (Product prod, int index)
        {
            bool ok = false;
            if ((prod != null) && CheckIndex ( index ))
            {
                productRegistry[index] = prod;
                ok = true;
            }
            return ok;
        }

        //Remove the object at position= index from the list
        public bool DeleteProduct (int index)
        {
            bool ok = false;
            if (CheckIndex ( index ))
            {
                productRegistry.RemoveAt ( index );
                ok = true;
            }

            return ok;
        }


        public bool CheckIndex (int index)
        {
            return (index >= 0) && (index < productRegistry.Count);

        }
        //Return the sum of the price of all the products
        public double TotalSum
        {
            get
            {
                double sum = 0.0;
                for (int i = 0; i < Count; i++)
                {
                    sum += ((Product)productRegistry[i]).TotalValue;
                }

                return sum;
            }
        }

        }//class
}

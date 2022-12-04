using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProductMngr
{
    //This is only a continuation of the ProductManager (notice the declaration "partial")
    //The partial class handles all text data file handling

    public partial class ProductManager
    {
        private List<Product> productRegistry;

        //Constructor

        public ProductManager()
        {
            productRegistry = new List<Product>();
        }

        //Write data from arrayList to an xml file

        //1. open the file
        //2. write data to file
        //3. close file
        public bool WriteToTextFile(string fileName, out string errorMsg)
        {
            bool ok = false;
            StreamWriter writer = null;
            errorMsg = string.Empty;

            try
            {
                //1. open the file for writing. If the file exist, it will be emptied first,
                //if not the file will be created
                 writer = new StreamWriter(fileName);

                for (int i = 0; i < productRegistry.Count; i++)
                {
                    Product prod = (Product)productRegistry[i];

                    //2. write the values to the file with tab-separated
                    //Note: writer.WriterLine works in the same way as Console.WriteLine
                    //Save data and separate them by a tab
                    writer.WriteLine("{0}\t{1}\t{2}", prod.Name, prod.Price, prod.Count);
                }
                writer.Flush();  //Empty the buffer to file (immediately)
                ok = true;
            }
            catch (Exception e)
            {
                errorMsg = "WritetoTextFile: " + e.Message;
            }
            finally   //always performed even when no exception is thrown
            {
                //3.  Close the file
                writer.Close();
            }
            return ok;
        }//WriteToTextFile

        //Retrieve data from a textfile to arraylist
        //As an alternative, you can use TextReader 
        //1. open the file
        //2. get data from file
        //3. close file
        public bool ReadFromTextFile(string fileName, out string errorMsg)
        {
            bool ok = false;
            StreamReader reader = null;
            errorMsg = string.Empty;

            try
            {
                //1. File must exit - otherwise exception is thrown
                reader = new StreamReader(fileName, Encoding.UTF8);

                while (!reader.EndOfStream) //read to end of file
                {
                    Product prod = new Product();

                    //2. get the values from a row in the file in the same ordning there were written
                    string strRowData = reader.ReadLine(); //read the whole row
                    string[] strValues = strRowData.Split('\t');  //tab separated
                    prod.Name = strValues[0].Trim();  //delete spaces

                    prod.Price = Convert.ToDouble(strValues[1].Trim());
                    prod.Count = Convert.ToInt32(strValues[2].Trim());

                    productRegistry.Add(prod);
                }
                ok = true;

            }
            catch (Exception e)
            {
                errorMsg = "WritetoTextFile: " + e.Message;
            }
            finally   //always performed even when no exception is thrown
            {
                //3.  Close the file
                reader.Close();
            }
            return ok;
        }//ReadFrom..


    }
}

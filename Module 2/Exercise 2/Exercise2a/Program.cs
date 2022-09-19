using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2a
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Exercise2a - for statement";

            //Create an object of the 
            ForStatements obj = new ForStatements();
            obj.Start();
           
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}

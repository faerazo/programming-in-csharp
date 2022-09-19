//Code example
//Created:   By Farid Naisan, 20140131
//Revised:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumNumbersCS
{
    public class NumberProgram
    {
        static void Main(string[] args)
        {
            Console.Title = "Sum up  numbers";

            //declare and create an object of the class Numbers
            Numbers numObj = new Numbers();
            numObj.Start();
           
            //Let the console window stay on the screen
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputProgram
{
    /// <summary>
    /// This program  tests the validity of numeric values given by the user
    /// </summary>
    class InputProgram
    {
        static void Main (string[] args)
        {
            // Declare and create an object of the Menu class
             Menu menu = new Menu ( );
            // Call the start method of the Menu class to 
            // get started.
            menu.ShowMenu ( );
        }
    }
}
//The Zip-file contains a VS2015 solution.The purpose of the application is to create a helper class Input that can be used in all Console applications.When an integer is to be inputted by the user, the program test so the expression provided is an integer.The project contains a class called Input with a static method.Static methods can be called by the class name directly without creating an instance of the class. Check the source code in this order:  the Main-method, the ShowMenu method in the Menu class and finally the method contained in the Input class.  

//To do:  Make sure you can trace the code and how methods call each other.Then, write a method for reading a double value from the console and test it, exactly as for reading an integer.We can re-use the Input.cs in Assignment 2 and Assignment 3.

//ConsoleInput.zip (download, unzip and then start the application by double-clicking on the sln (or csproj) file.
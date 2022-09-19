//MenuProgram.cs
//Created:  Farid Naisan, 2008-06-13
//Revised:  
//Purpose:  This class tests the class Menu.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuAppCS
{
    /// <summary>
    /// Start class to test the class Menu.
    /// The program shows a menu to the user and then shows the 
    /// current date and and time in different formats according
    /// to the user's choice.
    /// </summary>
    class MenuProgram
    {
        static void Main(string[] args)
        {
            // Declare and create an object of the Menu class
            Menu menu = new Menu();
            // Call the start method of the Menu class to 
            // get started.
            menu.ShowMenu();
        }
    }
}

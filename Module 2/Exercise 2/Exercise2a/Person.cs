using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp
{
    class Person
    {
        //instance variables (fields)
        private string name;

        //Method changing an instance variable.

        public void SetName()
        {
            //ex 1:
            name = "No name";
            //ex 2
            name = Console.ReadLine();
        }
    }
}

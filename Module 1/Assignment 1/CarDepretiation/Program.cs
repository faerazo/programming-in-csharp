using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDepretiation
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable for car
            Car carObj = new Car();

            // album start
            carObj.Start();

            Console.ReadLine();
            Console.WriteLine("Thanks for using our depretiation calculator!");
            Console.ReadLine();
        }
    }
}

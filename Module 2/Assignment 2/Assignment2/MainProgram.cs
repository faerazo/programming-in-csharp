using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            Console.Title = "Strings, selection and iterationa in C#";
            FunFeatures funObj = new FunFeatures();
            funObj.Start();

            ContinueToNextPart(); 

            MathWork mathObj = new MathWork();
            mathObj.Start();

            ContinueToNextPart();

            TemperatureConverter tempObj = new TemperatureConverter();
            tempObj.Start();

        }

        private static void ContinueToNextPart()
        {
            Console.WriteLine("\nPress enter to continue to the next part...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

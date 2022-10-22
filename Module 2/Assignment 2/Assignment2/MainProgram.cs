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

            // start FunFeatures
            FunFeatures funObj = new FunFeatures();
            funObj.Start();

            ContinueToNextPart();

            // start MathWork
            MathWork mathObj = new MathWork();
            mathObj.Start();

            ContinueToNextPart();

            // start TemperatureConverter
            TemperatureConverter tempObj = new TemperatureConverter();
            tempObj.Start();

            ContinueToNextPart();

            //start WorkingSchedule
            WorkingSchedule workObj = new WorkingSchedule();
            workObj.Start();    

        }

        private static void ContinueToNextPart()
        {
            // ask user to continue to next part 
            Console.WriteLine("\nPress enter to continue to the next part...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

// VehicleProgram.cs  (Start Class)
// This line is a comment and will not be compiled 
// Code Sample - Console application
// Created: Farid Naisan


using System; // compiler is looking in the System namespace for the class, Console
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleApp
{
	public class VehicleProgram
	{
		public static void Main(string[] args)
		{
			//1. Declare a variable of the class Car
			Car carObj; // keeps track of where the data is in memory

			//2. Create the object in memory (allocate memory)
			carObj = new Car();  // 'new' calls the constructor (car.cs)

			//3. Use the services of this item
			carObj.ReadInputAndWriteInfo();

			// Program carries out its instructions (the above and ends here.
			// This goes so fast that the command window disappears
			// before you have a chance to see the results.
			// If we put the program in a read mode,
			// the program stops until you press the Enter key

			Console.WriteLine("Press enter to exit the program!");
			Console.ReadLine();  // read something
		}
	}
}

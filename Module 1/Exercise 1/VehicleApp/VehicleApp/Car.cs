// Car.cs
// This line is a comment and will not be compiled 
// Code Sample - Console application
// Created: Farid Naisan, June 2016
// Translated fr: Jens Lorentzson Sep 2017

using System; // compiler is looking in the System group after class Console
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Groupname for this application (like System)
namespace VehicleApp
{
	/// <summary>
	/// These lines are comments (XML compatible)
	/// This Class handles all about a car. The class is public and named Car.
	/// If you want to change the name, press F2 on your keyboard.
	/// This class is divided into three parts.
	/// </summary>
	public class Car
	{
		// Part 1: Instance Variables
		// --------------------------
		// Try not to use too many Instance Variables
		// Instance variables (attributes) that describes a car (any car)
		// Describes the state of the object, object is an instance of this class
		private string model;
		private int numOfDoors;
		private double price;
		private bool inspected;

		// Part 2: Constructor
		// -------------------
		// Constructor is a special method that is named the same as the class
		// and has no return type (void). A constructor is often used to initialize
		// instance variables. Every time an object (instance) of this class is
		// created with the 'new' keyword, the constructor is executed automatically
		// just before the object is created.
		public Car()
		{
			Console.WriteLine("Inside the constructor, a new car is coming to the world!\n");
			model = "Not known.";  // model not specified
			numOfDoors = 4;        // standard
			price = 0.0;           // price not known from the beginning
			inspected = false;     // assume that the car has not been inspected (initialize)
		}

		// Part 3: Methods
		// ---------------
		// Other methods that executes instructions.
		// This class has three more methods

		// Read input data and print out everything about the car
		public void ReadInputAndWriteInfo()
		{
			// a. Ask the user if the car is inspected and save the answer
			ReadInfoAboutTheInspection();

			// b. Write all the info that is stored on the car so far
			ShowCarInfo();
		}

		// Read input data
		public void ReadInfoAboutTheInspection()
		{
			Console.WriteLine("Is the car inspected (y / n)?");

			// Read a character from the user and save it in a temporary variable (response)
			char response = char.Parse(Console.ReadLine());

			// If the user types 'y' or 'Y' is the vehicle inspected
			// Equals '==' returns true if the parts are equal
			// Or '||' returns true if both parts are true
			if ((response == 'y') || (response == 'Y'))
				inspected = true;
			else
				inspected = false;
		}

		// Print out everything about the car
		public void ShowCarInfo()
		{
			Console.WriteLine("The following information is available about the car:\n\n");

			// The value stored in the variable 'inspected' is either true or false.
			// If 'inspected' is true, the car is inspected - How to write this as text?
			// Here we go...
			string strInspected = "The car is not inspected.";

			if (inspected)  // The same as writing: if (inspected == true)
				strInspected = "The car is inspected.";  // This text is used if the car has been inspected

			// Formatting a string, a good way to write the contents of variables
			// {0} is replaced by variable: model
			// {1} is replaced by variable: numOfDoors
			// {2} is replaced by variable: price
			// {3} is replaced by variable: strInspected
			// '\n' makes a new line.
			string strOut = string.Format("Model: {0} Doors:{1} Price: {2} \nInspection: {3}\n",
					  model, numOfDoors, price, strInspected);

			Console.WriteLine(strOut);
		}
	}
}

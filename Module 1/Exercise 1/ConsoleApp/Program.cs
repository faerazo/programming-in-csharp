using System;


public class Program
{
	public static void Main()
	{
		//System.Console.WriteLine("Testing my first C# program!");
	

		Console.Title = "My First C# Program";
		Console.BackgroundColor = ConsoleColor.Blue;
		Console.ForegroundColor = ConsoleColor.White;
		Console.Clear();

		Product product = new Product(); //Create an object of the Product class
		product.ReadName(); //call (activate) a method of the object

		Console.WriteLine(); //write a blank line on the screen
		product.ReadPrice();

		Console.WriteLine(); //write a blank line on the screen
		product.ReadCount();
		Console.WriteLine(); //write a blank line on the screen
		product.CalculateTotalPrice();

		Console.WriteLine("Press Enter to exit!");
		Console.ReadLine(); //Put the Prompt Window in a input mode so it does not close
	}
}
	



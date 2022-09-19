using System;

class Product
{
	//input variables
	private string name; //To store name of the product as text
	private double price; //To store price as reel number (with or without decimals) 
	private int count;  //To store the quantity of the product as whole number.


	public void ReadName()
	{
		Console.WriteLine("Name of the product?"); //Writes the text to the Console window
		name = Console.ReadLine(); //returns a line of text from the Console window
		Console.WriteLine("The product's name is: " + name);
	}

	//Ask the user to feed in the price of the product
	public void ReadPrice()
	{
		Console.WriteLine("Price of the product?"); //Prompt the user for price

		//User's input is a text (ex "34.5")
		string strPrice = Console.ReadLine();
		//convert the text to its corresponding number ex. "34.5" (4 chars) --> 34.5 (number 34.5)
		price = double.Parse(strPrice);

		//Confirm the price.  ToString converts the price to text: ex 34.5 (number) --> "34.5" (chars)
		Console.WriteLine("The product's price is: " + price.ToString());
		
	}

//Ask the user to feed in the quantity of the product as a whole number
public void ReadCount()
{
	Console.WriteLine("Quantity of this product (a whole number)?"); //Prompt the user for price

	//User's input is a text (ex "34")
	string strCount = Console.ReadLine();
	//Convert the text to its corresponding number ex. "34" (2 chars) --> 34 (number 34)
	count = int.Parse(strCount);

	//Confirm the input.  ToString converts the count to text: ex 34 (number) --> "34" (chars)
	Console.WriteLine("The no of this product (units): " + count.ToString());
}

//Calculate the total price = count * price.  Display the result to the user
public void CalculateTotalPrice()
{
	double totalPrice = count * price;
	//display the result to the user, put a space between two words
	Console.WriteLine("Total price for " + count.ToString() + " units of " + name + " = " + totalPrice);
}

}


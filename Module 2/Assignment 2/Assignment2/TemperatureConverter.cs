using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment2
{
    class TemperatureConverter
    {
        public void Start()
        {
            // bool variable for do-while loop, the loop will continue if the user decide to run it again
            bool done = false;

            do
            {
                // show menu
                ShowMenu();

                done = AnswerUser();

            } while (!done);
        }

        private void ShowMenu()
        {
            // temperature converter header
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("                 TEMPERATURE CONVERTER                 ");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("                Celsius to Fahrenheit         : 1      ");
            Console.WriteLine("                Fahrenheit to Celsius         : 2      ");
            Console.WriteLine("                Exit                          : 0      ");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();

        }

        private bool AnswerUser()
        {
            bool success = false; // variable to record if user provides a integer

            bool response = false; // variable to stop the do-while loop in Start()

            // do-while for getting the right answer 0, 1, 2
            do
            {
                // ask user for a answer between 0 and 2
                Console.Write("Your choice: ");
                string textValue = Console.ReadLine();

                // bool variable to record is the answer is a integer
                success = int.TryParse(textValue, out int choice);

                // if does not provide an integer an error message appears
                if (!success)
                {
                    Console.WriteLine("Wrong input!");
                }
                // otherwise, the program analyzes the answer and provides the tables 
                else
                {
                    if ((choice >= 0) && (choice <= 2)) // if the user provides an answer between 0 and 2, the program runs the respective tables
                    {
                        // bool variable is true when the user provides a good answer
                        success = true;

                        // if choice is 1, call celsius to farenheit method
                        if (choice == 1)
                        {
                            CelsiusToFarenheit();
                            response = false; // response is false so the do while loop in Start() can continue running
                        }
                        // if choise is 2, call farenheit to celsius method
                        else if (choice == 2)
                        {
                            FarenheitToCelsius();
                            response = false; // response is false so the do while loop in Start() can continue running
                        }
                        // if choise is not 1 or 2, the program ends with a message
                        else
                        {
                            Console.WriteLine("Bye, bye");
                            response = true;// response is true so the do while loop in Start() stop
                        }
                    }
                    else
                    {
                        // user doesn't provide a good answer, so an error message appears in the console
                        success = false;
                        Console.WriteLine("Please choose 0, 1, or 2 ");
                    }
                }

            } while (!success);
            return response; // return the response to know whether Start() continues
        }


        private void CelsiusToFarenheit()
        {
            // constant with the maximum limit in celsius
            const int max = 100;

            // for loop to get all transformations from celsius to farenheit between 0 and 100
            for (int i = 0; i <= max; i+=4)
            {
                // operation to transform farenheit to celsius
                double farenheit = 9/5.0 * i + 32;
                Console.WriteLine($"{i, 6:f2}" + " C = " + $"{farenheit, 6:f2}" + " F");
            }
        }


        private void FarenheitToCelsius()
        {
            // constant with the maximum limit in farenheit
            const int max = 212;

            // for loop to get all transformation from farenheit to celsius between 0 and 212
            for (int i = 0; i <= max; i+=4)
            {
                // operation to transform celsius to farenheit
                double celsius = 5/ 9.0 * (i - 32);
                Console.WriteLine($"{i,6:f2}" + " F = " + $"{celsius,6:f2}" + " C");
            }
        }


    }
}

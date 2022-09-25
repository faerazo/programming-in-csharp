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
            bool done = false;

            do
            {
                // show menu
                ShowMenu();

                //run again
                done = RunAgain();

            } while (!done);
        }

        private void ShowMenu()
        {
            // converter header
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

            
            bool success = false;

            // do-while for getting the right answer 0, 1, 2
            do
            {
                Console.Write("Your choice: ");
                string textValue = Console.ReadLine();
                success = int.TryParse(textValue, out int choice);

                // if statement to check if the user provides a good answer
                if (!success)
                {
                    Console.WriteLine("Wrong input!");
                }
                else
                {
                    if ((choice>=0) && (choice <= 2)) // if the user provides the right answers, the program runs the respective tables
                    {
                        success = true;

                        // if to call converters
                        if (choice == 1)
                        {
                            CelsiusToFarenheit();
                        }
                        else if (choice == 2)
                        {
                            FarenheitToCelsius();
                        }
                        else
                        {
                            Console.WriteLine("Bye, bye");
                        }
                    }
                    else
                    {
                        success = false;
                        Console.WriteLine("Please choose 0, 1, or 2 ");
                    }
                }

            } while (!success);

        }

        private void CelsiusToFarenheit()
        {
            const int max = 100;

            // for loop to get all transformations from celsius to farenheit between 0 and 100
            for (int i = 0; i <= max; i++)
            {
                double farenheit = 9/5.0 * i + 32;
                Console.WriteLine($"{i, 6:f2}" + " C = " + $"{farenheit, 6:f2}" + " F");
            }
        }


        private void FarenheitToCelsius()
        {
            const int max = 212;

            // for loop to get all transformation from farenheit to celsius between 0 and 212
            for (int i = 0; i <= max; i++)
            {
                double celsius = 5/ 9.0 * (i - 32);
                Console.WriteLine($"{i,6:f2}" + " F = " + $"{celsius,6:f2}" + " C");
            }
        }


        private bool RunAgain()
        {

            bool response = false; // true = y, false = n

            Console.WriteLine();
            Console.WriteLine("Do you want to run the program again (y/n)?");
            Console.WriteLine();

            bool goodResponse = false;

            // do-while for getting a right answer: y or n
            do
            {
                string str = Console.ReadLine();
                str = str.ToLower();

                if (str[0] == 'y')
                {
                    response = false;
                    goodResponse = true;
                }
                else if (str[0] == 'n')
                {
                    response = true;
                    goodResponse = true;
                }
                else
                {
                    Console.WriteLine("Please use Y/N or y/n!");
                    goodResponse = false;
                }
            } while (!goodResponse);

            return response;
        }

    }
}

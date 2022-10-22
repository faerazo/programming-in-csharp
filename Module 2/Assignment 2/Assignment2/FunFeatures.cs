using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment2
{
    class FunFeatures
    {
        private string name = "";
        private string email = "";

        public void Start()
        {
            // present the developer name and course
            Introduce();

            // bool variable for do-while loop, the loop will continue if the user decide to run it again
            bool done = false;

            do
            {
                // method to predict the day
                PredictTheDay();

                // length of a given text
                CalculateStringLength();

                // run again
                done = RunAgain();

                if (!done)
                {
                    Console.WriteLine();
                    Console.WriteLine("Welcome back, " + name);
                    Console.WriteLine();
                }

            } while (!done);

        }

        private void Introduce()
        {
            // student introduction: name and course
            Console.Write("Hey there, my name is Francisco and I am a student of the Programming in C# - HT22");
            Console.WriteLine();
            Console.WriteLine("Help me with the following questions about yourself...");
            Console.WriteLine();

            // ask user information
            ReadName();
        }
        

        public void ReadName()
        {
            // ask user first name
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            // ask user last name
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            lastName = lastName.ToUpper();

            // concatenate last and first name
            name = lastName + ", " + firstName;

            // ask email address
            Console.WriteLine("What is your email address?");
            email = Console.ReadLine();

            // print name and email
            Console.WriteLine();
            Console.WriteLine("This is your information:");
            Console.WriteLine("Full name: " + name);
            Console.WriteLine("E-mail address: " + email);
            Console.WriteLine();
        }
        
        public void PredictTheDay()
        {
            int day = 0;
            bool proceedDay = false;

            // while loop for getting a correct answer from the user between 1 and 7, it will return an error if the user doesn't provive a good response
            while (!proceedDay)
            {
                // ask the user for a number
                Console.WriteLine("Please select a number between 1 and 7: ");
                string textValue = Console.ReadLine();

                // bool variable to record if the answer provided by the user is a integer
                bool success = int.TryParse(textValue, out day);

                // if sucess is true (user provide an integer) and this integer is between 0 and 7, the program can switch that integer with a comment
                if ((success) && (day > 0) && (day <= 7))
                {
                    proceedDay = true;

                    // replacing the integer day with a comment
                    switch (day)
                    {
                        case 1:
                            Console.WriteLine("Monday: Keep calm my friend! You can fall apart!");
                            break;
                        case 2:
                        case 3:
                            Console.WriteLine("Tuesday and Wednesday break your heart!");
                            break;
                        case 4:
                            Console.WriteLine("Thursday, OMG, still one day to Friday!");
                            break;
                        case 5:
                            Console.WriteLine("It's Friday! You are in love!");
                            break;
                        case 6:
                            Console.WriteLine("Saturday, do nothing and do plenty of it!");
                            break;
                        case 7:
                            Console.WriteLine("And Sunday always comes too soon!");
                            break;
                    }
                }

                // error message when users provide an invalid answer
                if (!proceedDay)
                {
                    Console.WriteLine();
                    Console.WriteLine("Not in a good mode? This is not a valid date!");
                    Console.WriteLine();
                }
            }

        }

        public void CalculateStringLength()
        {
            // ask the user to provide a text or sentence
            Console.WriteLine();
            Console.WriteLine("Please enter a sentence or a text: ");
            string userString = Console.ReadLine();
            string userStringNoSpaces = String.Concat(userString.Where(c => !Char.IsWhiteSpace(c))); // remove all spaces in a string

            // two results, the first considers spaces as characters, the second remove all spaces from the string, in other words, it does not consider spaces as characters
            Console.WriteLine();
            Console.WriteLine("Your sentence or text has a total of " + userString.Length + " characters (considering spaces as characters)."); 
            Console.WriteLine("Your sentence or text has a total of " + userStringNoSpaces.Length + " characters (without considering spaces as characters).");

        }

        private bool RunAgain()
        {
            bool response = false; // true = y, false = n

            Console.WriteLine();
            // ask user to run the program again
            Console.WriteLine("Do you want to run the program again (y/n)?");

            bool goodResponse = false;

            // do-while for getting a right answer: y or n
            do
            {
                string str = Console.ReadLine();
                str = str.ToLower();

                // if user provides a Yes, the response is false (in the method Start() done = false keeps the do-while running) and the goodResponse is true because Yes is a valid answer 
                if (str[0] == 'y')
                {
                    response = false;
                    goodResponse = true;
                }
                // if user provides a No, the response is true (in the method Start() done = true stops the do-while) and the goodResponse is true because No is a valid answer
                else if (str[0] == 'n')
                {
                    response = true;
                    goodResponse = true;
                }
                // if user provides another answer, the program will ask user to provide a correct one, goodReponse is false because the answer is invalid
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

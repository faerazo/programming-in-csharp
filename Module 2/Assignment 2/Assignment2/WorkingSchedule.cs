using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class WorkingSchedule
    {
        // I decided to use a do-while loop which include if statements according to the answer that the use could provide, in this case, valid answer such as 0, 1, 2
        // or invalid answer such as integer outside the range [0,2] or any other type of response. 
        // This loop is inside the AnswerUser() method, the method return a reponse variable which is assgined to done inside the Start() method, so the program
        // can understand if it necessary to continue running the WorkingSchedule (when answer are 1 or 2) or stop it (when answer is 0). 
        public void Start()
        {
            // bool variable for do-while loop, the loop will continue if the user decide to run it again
            bool done = false;

            do
            {
                // call showmenu which contains the code for the week schedule
                ShowMenu();

                // call method run again and record the user answer into done, so the loop continue or stop
                done = AnswerUser();

            } while (!done);

        }

        private void ShowMenu()
        {
            // menu for working schedule 
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("                   YOUR WORK SCHEDULE               ");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("  Show a list of the weekends to work      : 1      ");
            Console.WriteLine("  Show a list of the nights to work        : 2      ");
            Console.WriteLine("  Exit                                     : 0      ");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
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

                // record if the variable is integer
                success = int.TryParse(textValue, out int choice);

                // if it is not an integer, an error message appears
                if (!success)
                {
                    Console.WriteLine("Wrong input!");
                }
                // otherwise, the program analyzes the answer and provides the tables depending on the integer
                else
                {
                    if ((choice >= 0) && (choice <= 2)) // make sure the integer is between 0 and 2
                    {
                        success = true;// variable is true when the user provides a good answer

                        if (choice == 1) // if choice is 1, call celsius to farenheit method
                        {
                            WeekendShifts();
                            response = false; // response is false so the do while loop in Start() can continue running
                        }
                        else if (choice == 2) // if choise is 2, call farenheit to celsius method
                        {
                            NightShifts();
                            response = false; // response is false so the do while loop in Start() can continue running
                        }
                        // if choise is not 1 or 2, the program ends with a message
                        else
                        {
                            Console.WriteLine("Bye, bye");
                            response = true;// response is true so the do while loop in Start() stop
                        }
                    }
                    else // user doesn't provide a good answer, so an error message appears in the console
                    {
                        success = false;
                        Console.WriteLine("Please choose 0, 1, or 2 ");
                    }
                }

            } while (!success);
            return response; // return the response to know whether Start() continues
        }

        private void WeekendShifts()
        {
            // constant with the maximum limit of weeks
            const int max = 52;

            // constant for number of columns
            const int columns = 5;
            int col = 0;

            // for loop for printing every other second weekend
            for (int i = 1; i <= max; i+=2)
            {
                col++;
                Console.Write("Week " + string.Format("{0,2}", i) + "     ");

                // if col reach the limit of 5, add a space and restart col to zero
                if (col >= columns)
                {
                    Console.WriteLine();
                    col = 0;
                }
            }

        }

        private void NightShifts()
        {
            // constant with the maximum limit of weeks
            const int max = 52;

            // constant for number of columns
            const int columns = 5;
            int col = 0;

            // for loop for printing every 4th weekend
            for (int i = 1; i <= max; i += 3)
            {
                col++;
                Console.Write("Week " + string.Format("{0,2}", i) + "     ");

                // if col reach the limit of 5, add a space and restart col to zero
                if (col >= columns)
                {
                    Console.WriteLine();
                    col = 0;
                }
            }
        }




    }
}

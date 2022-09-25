using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class MathWork
    {
        
        public void Start()
        {
            bool done = false;

            do
            {
                // ask numbers
                SumberNumbers();

                // run again
                done = RunAgain();

            } while (!done);

            // print multiplication table
            PrintMultiplicationTable();
        }
        
        
        public void SumberNumbers()
        {
            Console.WriteLine("Cummulative sum between any two numbers");
            
            int number1;
            int number2;

            bool successN1 = false;

            // do-while loop for getting a right answer from the user
            do
            {
                // ask first number
                Console.WriteLine("Provide a start number: ");
                string strNum1 = Console.ReadLine();
                successN1 = int.TryParse(strNum1, out number1);

                if (!successN1)
                {
                    Console.WriteLine("Wrong input!");
                }

            } while (!successN1);


            bool successN2 = false;

            // do-while loop for getting a right answer from the user
            do
            {
                // ask second number
                Console.WriteLine("Provide an end number: ");
                string strNum2 = Console.ReadLine();
                successN2 = int.TryParse(strNum2, out number2);

                if (!successN2)
                {
                    Console.WriteLine("Wrong input!");
                }

            } while (!successN2);

            int totalSum;


            if (number1 < number2) // condition for changing number positions if the first is lower than the second number
            {
                totalSum = SumNumbers(number1, number2);
                Console.WriteLine();
                Console.WriteLine("The sum of numbers from " + number1 + " to " + number2 + " is: " + totalSum);
                Console.WriteLine();
                Console.WriteLine("Even numbers between " + number1 + " and " + number2 + ": ");
                PrintEvenNumbers(number1, number2);
            } 
            else // condition for changing number positions 
            {
                totalSum = SumNumbers(number2, number1);
                Console.WriteLine();
                Console.WriteLine("The sum of numbers from " + number2 + " to " + number1 + " is: " + totalSum);
                Console.WriteLine("Even numbers between " + number2 + " and " + number1 + ": ");
                PrintEvenNumbers(number2, number1);
            }
        }


        private int SumNumbers(int start, int end)
        {
            int sum = 0;

            // for loop for addding all the values between a range 
            for (int i = start; i <= end; i++)
            {
                sum = sum + i;
            }
            return sum;
        }

        private void PrintEvenNumbers(int start, int end)
        {
            const int columns = 5;
            int col = 0;
            
            // for loop for printing even numbers between a range
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    col++;
                    Console.Write($"{i, 6}");
                    
                    if (col >= columns)
                    {
                        Console.WriteLine();
                        col = 0;
                    }
                }
            }
        }

        public void PrintMultiplicationTable()
        {
            Console.WriteLine("******** Mutiplication Table ********");
            const int max = 12;

            // nested for loop for getting a multiplication table 
            for (int i = 1; i <= max; i++)
            {
                for (int j = 1; j <= max; j++)
                {
                    Console.Write($"{i*j,6}");
                }
                Console.Write("\n");
               
            }

        }


        private bool RunAgain()
        {
            bool response = false; // true = y, false = n

            Console.WriteLine();
            Console.WriteLine("Do you want to calculate again (y/n)?");
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

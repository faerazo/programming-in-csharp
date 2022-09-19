using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFair
{
    class TicketSeller
    {
        private string buyerName;
        private double ticketPrice = 100;
        private int numOfAdults;
        private int numOfChildren;
        private double amountToPay;

        public void Start()
        {
            Console.WriteLine("************************");
            Console.WriteLine("*Welcome to Kid's Fair!*");
            Console.WriteLine("************************");
            Console.WriteLine();
            Console.WriteLine("Get a 75% discount on tickets for children!");
            Console.WriteLine();

            // ask buyer's name
            ReadName();

            // ask the number of adults
            ReadAdults();

            // ask the number of kids
            ReadChildren();

            // total payment
            TotalPayment();

        }

        public void ReadName()
        {
            // name of buyer
            Console.WriteLine("Your name please: ");
            buyerName = Console.ReadLine();
        }

        public void ReadAdults()
        {
            // number of adults
            Console.WriteLine("Number of adults: ");
            string textValue = Console.ReadLine();
            numOfAdults = int.Parse(textValue); // convert string to integer
        }

        public void ReadChildren()
        {
            // number of children
            Console.WriteLine("Number of children: ");
            string textValue = Console.ReadLine();
            numOfChildren = int.Parse(textValue); // convert string to integer
        }

        public void TotalPayment()
        {
            double kidsPayment = ticketPrice * 0.25 * numOfChildren;
            double adultPayment = ticketPrice * numOfAdults;
            amountToPay = kidsPayment + adultPayment;
            
            
            Console.WriteLine();
            Console.WriteLine("Amount to pay: " + amountToPay);
            Console.WriteLine("Thanks for your purchase " + buyerName + ". Enjoy your stay!");
        }
    }


}

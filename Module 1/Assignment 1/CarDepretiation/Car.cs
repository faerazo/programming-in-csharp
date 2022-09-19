using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDepretiation
{
    class Car
    {
        private string ownerName;
        private double originalPrice;
        private int carAge;
        private double currentPrice;
        private DateTime todayDate;

        public void Start()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("*Car Depretiation Calculator!*");
            Console.WriteLine("******************************");
            Console.WriteLine();

            // ask name 
            ReadName();

            // ask original price
            ReadPrice();

            // ask car age
            ReadAge();

            // current price
            CurrentValue();
        }

        public void ReadName()
        {
            // name of owner
            Console.WriteLine("What is your name? ");
            ownerName = Console.ReadLine();
        }

        public void ReadPrice()
        {
            // original price
            Console.WriteLine("What was the original price of your car?");
            string textValue = Console.ReadLine();
            originalPrice = double.Parse(textValue); // convert string to double
        }

        public void ReadAge()
        {
            // years of the car
            Console.WriteLine("How old is your car (in years)? ");
            string textValue = Console.ReadLine();
            carAge = int.Parse(textValue); // convert string to integer
        }

        public void CurrentValue()
        {
            // cars have an average life of 9 years
            int remainingLife = 9 - carAge;
            currentPrice = originalPrice / 9 * remainingLife;

            string textCurrentPrice = string.Format("{0:N2}", currentPrice); // keep only two decimals points

            todayDate = DateTime.Now;

            Console.WriteLine();
            Console.WriteLine("Hi " + ownerName + ", on " + todayDate + " your car has a estimated value of " + textCurrentPrice);
        }
    }
}

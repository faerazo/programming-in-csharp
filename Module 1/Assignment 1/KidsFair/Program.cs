using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace KidsFair
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // variable for class pet
            Pet petObj;

            // create the object in memory
            petObj = new Pet();

            // pet start
            petObj.Start();

            Console.WriteLine("Press Enter to start the next object!");
            Console.ReadLine();

            // variable for class ticketseller
            TicketSeller ticketObj;

            // create the object in memory
            ticketObj = new TicketSeller();

            // ticket start
            ticketObj.Start();

            Console.WriteLine("Press Enter to start the next object!");
            Console.ReadLine();

            // variable for album
            Album albumObj;

            // create the object in memory
            albumObj = new Album();

            // album start
            albumObj.Start();

            Console.ReadLine();
            Console.WriteLine("Thanks for your participation!");
            Console.ReadLine();
        }
    }
}

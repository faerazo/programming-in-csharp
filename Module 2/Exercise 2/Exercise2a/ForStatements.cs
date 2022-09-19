using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2a
{
    public class ForStatements
    {

        public void Start()
        {
            SumNumbers();
            SumNumbersFromOneTo();
        }
 
        //Calculate sum of numbers 1 to 20
        public void SumNumbers()
        {
            int sum = 0; 
            for (int i = 1; i <= 20; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("The sum of 1 to 20 is: " + sum);
        }
        //Questions:  why sum is set to zeor
        //What happens if 

        public void SumNumbersFromOneTo()
        {
            int endNumber;
            int sum = 0;

            Console.WriteLine("Sum up numbers from 1 to x.");
            Console.Write("Give x: ");
            string str = Console.ReadLine();
            endNumber = int.Parse(str);

            for (int i = 1; i <= endNumber; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("The sum of 1 to " + endNumber + " is: " + sum);
        }
    }


}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KidsFair
{
    class Pet
    {
        private string petName;
        private int petAge;
        private bool isPetFemale;

        public void Start()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("*Pet Owner Register!*");
            Console.WriteLine("*********************");
            Console.WriteLine();

            // ask pet's name
            ReadName();

            // ask pet's age
            ReadAge();

            // ask pet's gender
            ReadGender();

            // show pet's information
            ShowPetInfo();
        }

        public void ReadName()
        {
            // name of the pet
            Console.WriteLine("What is the name of your pet? ");
            petName = Console.ReadLine();
        }

        public void ReadAge()
        {
            // age of the pet
            Console.WriteLine("What is " + petName + "'s age? ");
            string textValue = Console.ReadLine();
            petAge = int.Parse(textValue); // convert string to integer
        }

        public void ReadGender()
        {
            // gender of the pet
            Console.WriteLine("Is " + petName + " a female? Please reply only with Yes or No");
            string gender = Console.ReadLine();
            gender = gender.Trim().Substring(0); // take the first charact of the response
            char response = gender[0];

            if ((response == 'y') || (response == 'Y'))
                isPetFemale = true;
            else
                isPetFemale = false;
        }

        public void ShowPetInfo()
        {
            string strGender = "male";
            if (isPetFemale == true)
                strGender = "female";

            Console.WriteLine();
            Console.WriteLine("The following information is available about your pet:");
            string nameOut = "Pet's name: " + petName;
            string ageOut = "Pet's age: " + petAge;
            string genderOut = "Pet's gender: " + strGender;

            Console.WriteLine(nameOut);
            Console.WriteLine(ageOut);
            Console.WriteLine(genderOut);

        }
    }
}

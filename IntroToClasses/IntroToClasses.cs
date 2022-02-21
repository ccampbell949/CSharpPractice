using System;

namespace IntroToClasses
{
    class Program //class called "program"
    {
        // create some variables to store details about the Person,

       private static string lName, fName, dob, address, town, pCode, phone;

        //create a reference to the Person
       private static Person aNewPerson; //empty object reference - pointer to a location in memory


        static void Main(string[] args)
        {
            //Read in information from the user
            ReadPersonDetails();



            //Instantiate (or create a new instance) of the Person class using the above information

            aNewPerson = new Person(fName, lName, dob, address, town, pCode, phone);

            Console.WriteLine("Information stored");
            Console.WriteLine();

            //output the information stored in the class
            DisplayPersonDetails();

            //changing information in an instance
            Console.WriteLine("Change Person's address and phone");
            Console.Write("Please enter new address: ");
            address = Console.ReadLine();
            Console.Write("Please enter new postcode: ");
            pCode = Console.ReadLine();
            Console.Write("Please enter new Phone number: ");
            phone = Console.ReadLine();

            //Update the inforamtion for the person by assigning new values to the public property

            aNewPerson.Address = address;
            aNewPerson.PostCode = pCode;
            aNewPerson.Phone = phone;

            Console.WriteLine("Details updated");

            DisplayPersonDetails();
            

        }

        private static void ReadPersonDetails()
        {
            //read in data from the user

            Console.WriteLine("Please enter person details:");
            Console.Write("First Name: ");
            fName = Console.ReadLine();  //Read only reads a single character, readline reads a whole string

            Console.Write("Last Name: ");
            lName = Console.ReadLine();

            Console.Write("Date of Birth: ");
            dob = Console.ReadLine();

            Console.Write("Address: ");
            address = Console.ReadLine();

            Console.Write("Town: ");
            town = Console.ReadLine();

            Console.Write("Post Code: ");
            pCode = Console.ReadLine();

            Console.Write("Phone Number: ");
            phone = Console.ReadLine();
        }

        private static void DisplayPersonDetails()
        {
            Console.WriteLine("Stored Person Details:");
            //accessing the public property in each case will print out the stored value

            Console.WriteLine("First Name: " + aNewPerson.FirstName);
            Console.WriteLine("Last Name: " + aNewPerson.LastName);
            Console.WriteLine("Date of Birth: " + aNewPerson.DOB);
            Console.WriteLine("Address: " + aNewPerson.Address);
            Console.WriteLine("Town: " + aNewPerson.Town);
            Console.WriteLine("Post Code: " + aNewPerson.PostCode);
            Console.WriteLine("Phone Number: " + aNewPerson.Phone);
        }
    }
}

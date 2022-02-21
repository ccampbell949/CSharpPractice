using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToClasses
{
    public class Person //"public" is an accessability modifier
    {

        //declare variables to store information about the Person (ass classess need to have a capital letter)

        private string firstName;
        private string lastName;
        private string dob;
        private string address;
        private string town;
        private string postCode;
        private string phoneNumber; //private dont want variables to be publicly accessable from outside this class

        // private variables are accessible only within the class. They are encapsulated

        //create a means of publicly accessing our private variables

        //Getters and setters - as used in Java 

        //Getter
        public string GetFirstName()
        {
            return firstName;
        }

        //Setter
        public void SetFirstName(string name) //void as nothing is returned
        {
            //assign the paramter value to the variable
            firstName = name;
        }

        //Public properties - as used in C#

        //need to create a "public property" each private variable

        public string FirstName //capital first letter. Used as reference
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value; //Person.FirstName will return firstName
            }                      //Setting this equal to value will set the variable equal to 
        }                          //the vlaue given in the input parameters of the constructor.

        public string LastName
        {
            get
            {
                return lastName;

            }
            set
            {
                lastName = value;
            }
        }

        public string DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string Town
        {
            get
            {
                return town;
            }

            set
            {
                town = value;
            }

        }

        public string PostCode
        {
            get
            {
                return postCode;
            }
            set
            {
                postCode = value;
            }
        }

        public string Phone
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        //Constructors - used when creating or instantiating the class
        //constructor must have the class name

        //Default constructor

        public Person()
        {
            //no parameters specified - use default values which we define ourselves

            lastName = "Smith";
            firstName = "John";
            dob = "01/01/1990";
            address = "Main Street";
            town = "Bangor";
            postCode = "BT20 1AA";
            phoneNumber = "12345678910";
        }

        //Parameterised constructor

        public Person(string fname, string lname, string Dob, string add, string twn,
            string pcode, string ph)
        {
            //parameters have been entered, these can be stored in our Person attributes
            lastName = lname;
            firstName = fname;
            dob = Dob;
            address = add;
            town = twn; //could also use "this.town" to refer to the variable town that is declared in the person class
            postCode = pcode;
            phoneNumber = ph;
        }

        //second parameterised constructor
        //this one will have a different parameter list and thus a different method signature

        public Person(string fName, string lName) //only takes first name and last name
        {
            //assign supplied parameters to attributes
            firstName = fName;
            lastName = lName;

            //assign remaining attributes default values

            dob = "01/01/1990";
            address = "Main Street";
            town = "Bangor";
            postCode = "BT20 1AA";
            phoneNumber = "12345678910";
        }
    }
        //can only have 1 default constructor, but you can have as many parameterised constructors as you need
}

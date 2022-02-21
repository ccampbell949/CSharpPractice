using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExample
{
    public class Student : Person //class must be public if you want to use them to create objects
    {
        //The colon syntax above signifies that the Student class is inheriting from the Person class

        //Declare variables first
        //declare variables which store informatrion about the STUDENT

        private int studentNumber;
        private string campus;
        private string course;
        private string tutorName;


        //now need to create public properties to access private attributes:

        public int StudentNumber//capital word to allow you to referce the variable, without accessing the lowercase one directly
        {
            get
            {
                return studentNumber; //returns the lowercase variable if trying to access the capital letter variable
            }
            set
            {
                studentNumber = value; //value is the value you are giving the public property
            }                          //the value given in in the parameters of the class is the values carried through the class
        }                               //sets the studentNumber to the value given in the parameters

        public string Campus
        {
            get
            {
                return campus;
            }
            set
            {
                campus = value;
            }
        }

        public string Course 
        {
            get
            {
                return course;
            }
            set
            {
                course = value;
            }
        }

        public string TutorName
        {
            get
            {
                return tutorName;
            }
            set
            {
                tutorName = value;
            }
        }

        //now set default Constructor:

        public Student() : base() //base calls the constructor of the parent class Person
        {
            //set default values for Student. These are ALONGSIDE the default values from Person

            studentNumber = 12345678;
            course = "Computing";
            campus = "Bangor";
            tutorName = "Sam";
        }

        //Parameterised constructor
        //this constructor will take parameters for all student information andf all Person information
        //MUST include paramters which are present in the Person class

        public Student(string fName, string lName, string dob, string address, string twn, string pCode, 
            string phone, int number, string campus, string course, string tutor) : 
            
            base(fName, lName, dob, address, twn, pCode, phone)
        {
            //assign parameters with Student information to correct attributes
            //show which input paramters are relevant to which variable
            studentNumber = number;
            this.campus = campus; //"this" is used when 2 variables have same name
            this.course = course;
            tutorName = tutor;
        }

        //Parameterised constructor - number 2
        //this one will take parameters for first name and last name and student number
        
        public Student(string fName, string lName, int number) : base(fName, lName) //passing first name and last name off tyo base as thats is where they will be used
        {
            //now need to set input parameters to the variables
            //need to set variables only for the student number as the other 2 are taken care of in the Person class
            studentNumber = number;

            //now set default values for the other variables which aren't taking input parameters
            course = "Computing";
            campus = "Bangor";
            tutorName = "Sam";

        }//"base" will also try and match the inout list with the constructors in the parent class to try and find a match
        //eg a constructor asking for all variables, or may just 3 specific ones. if you put paramter list of say 4 or
        //3 different parameters than those specified in the parent class, this will give an error

        //name + parameter list = METHOD SIGNATURE

        //the method signature must match a constructor within the class, or there will be an error
            
    }
}

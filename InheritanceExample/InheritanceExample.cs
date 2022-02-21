using System;

namespace InheritanceExample
{
    class Program //class called "program"
    {
        // create some variables to store details about the Person,

       private static string lName, fName, dob, address, town, pCode, phone;

        
        //create variables to store Student information
        private static int studentNumber;
        private static string campus, course, tutor;
    //create a reference to the Student
        private static Student aNewStudent; //empty object reference - pointer to a location in memory

        static void Main(string[] args)
        {
            //Read in information from the user
            ReadPersonDetails();



            //Instantiate (or create a new instance) of the Student class using the above information

            aNewStudent = new Student(fName, lName, dob, address, town, pCode, phone, studentNumber, campus,
                course, tutor);

            Console.WriteLine("Information stored");
            Console.WriteLine();

            //output the information stored in the class
            DisplayPersonDetails();

            //changing information in an instance
            Console.WriteLine("Change Students Course, Campus and Tutor");
            Console.Write("Please enter new course: ");
            course = Console.ReadLine();
            Console.Write("Please enter new campus: ");
            campus = Console.ReadLine();
            Console.Write("Please enter new tutor name: ");
            tutor = Console.ReadLine();

            //Update the inforamtion for the Student by assigning new values to the public property

            aNewStudent.Course = course;
            aNewStudent.Campus = campus;
            aNewStudent.TutorName = tutor;

            Console.WriteLine("Details updated");

            DisplayPersonDetails();
            

        }

        private static void ReadPersonDetails()
        {
            //read in data from the user

            Console.WriteLine("Please enter student details:");
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

            Console.Write("Student Number: ");
            studentNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Couse: ");
            course = Console.ReadLine();

            Console.Write("Campus: ");
            campus = Console.ReadLine();

            Console.Write("Tutor: ");
            tutor = Console.ReadLine();
        }

        private static void DisplayPersonDetails()
        {
            Console.WriteLine("Stored Person Details:");
            //accessing the public property in each case will print out the stored value

            Console.WriteLine("First Name: " + aNewStudent.FirstName);
            Console.WriteLine("Last Name: " + aNewStudent.LastName);
            Console.WriteLine("Date of Birth: " + aNewStudent.DOB);
            Console.WriteLine("Address: " + aNewStudent.Address);
            Console.WriteLine("Town: " + aNewStudent.Town);
            Console.WriteLine("Post Code: " + aNewStudent.PostCode);
            Console.WriteLine("Phone Number: " + aNewStudent.Phone);
            Console.WriteLine("Student Number: " + aNewStudent.StudentNumber);
            Console.WriteLine("Course: " + aNewStudent.Course);
            Console.WriteLine("Campus: " + aNewStudent.Campus);
            Console.WriteLine("Tutor: " + aNewStudent.TutorName);
        }
    }
}

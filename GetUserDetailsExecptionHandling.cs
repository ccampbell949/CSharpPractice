using System;

namespace GetUserDetailsExecptionHandling
{
    class Program
    {
        private static int studentNumber;
        private static string studentLastName;
        private static string studentFirstName;
        private static string studentDOB;
        private static string studentAddress;
        private static string studentEmail;

        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration System");

            GetUserDetails();
        }

        private static void GetUserDetails()
        {
            //procedure for reading in details from keyboard
            //read in student information and store it

            try
            {
                Console.WriteLine("Please enter the following details: ");
                Console.Write("Student Number: ");
                studentNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Student Last Name: ");
                studentLastName = Console.ReadLine();
                Console.Write("Student First Name: ");
                studentFirstName = Console.ReadLine();
                Console.Write("Student DOB: ");
                studentDOB = Console.ReadLine();
                Console.Write("Student Address: ");
                studentAddress = Console.ReadLine();
                //call the GetEmailAddress procedure
                GetEmailAddress();
               

                //Confirmation message
                Console.WriteLine("Student Details Stored");
                Console.WriteLine();
            }

            catch (FormatException fe)
            {
                //Handle the FormatException
                //Display meaningful error message
                Console.WriteLine("Student Number must be numerical: ");

                //allow the user to recover from their error
                Console.WriteLine();

                //Recursively call the GetUserDetails procedure
                GetUserDetails();

                //to do this for each input, you would separate the inputs into separate functions and call relative one
            }

           
            catch (Exception e)
            {
                ////General Exception - catch any exceptions that were not previously caught
                //Console.WriteLine("Something went wrong during data entry");

                //Handle the exception
                Console.WriteLine(e.Message); //the variable e is the message we put in when we throw an exception
                //Allow the user to recover - recall procedure
                GetEmailAddress();
            }


        }

        private static void GetEmailAddress()
        {
            Console.Write("Student Email address: ");
            studentEmail = Console.ReadLine();

            if (!studentEmail.Contains("@")) //checking to see if a student email contains @ symbol
            {
                studentEmail = ""; //clear studentEmail

                Console.WriteLine("Invalid Email - Please try again");
                GetEmailAddress();
                
            }
            
        }


    }
}

using System;

namespace IntroToProcedures
{
    class Program
    {
        static void Main(string[] args)
        {

            //Void does not return any data
            //Main is a procedure - the void means that it does not return a value
            //Main is just the procedure name
            //Inside brackets is the input arguments

            //Write measn that the input is on the same line as the code

            //Display a program welcome message

            Console.WriteLine("Procedures Demo Application:");
            Console.WriteLine();
            //Get the users name by calling (or Invoking)
            //the GetUserName procedure

            GetUserName();
        }

        private static void GetUserName()
        {
            //private means it cannot be accessed outside the class
            //
            //Ask user their name
            Console.Write("Hello, please tell me your name: ");
            string strUsername = Console.ReadLine();

            //Print out user name

            //Call the GreetUser() procedure, passing in the stored user name
            //GreetUser(strUsername);
            GreetUser("Frank");
        }

        private static void GreetUser( String user)
        {

            //Print out user name

            Console.WriteLine("\nHi " + user + ", nice to meet you!");
            
        }
    }
}

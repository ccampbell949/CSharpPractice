using System;

namespace IfStatementLogin
{
    class Program
    {
        static void Main(string[] args)
        {

            //If statement login

            string strEnteredUsername;
            string strEnteredPassword;
            string strUsername = "Connor";
            string strPassword = "Dog";
            int intenteredAge = 16;
            int iAge = 15;

            Console.WriteLine("Please enter Username: ");
            strEnteredUsername = Console.ReadLine();

            Console.WriteLine("Please enter Password: ");
            strEnteredPassword = Console.ReadLine();

            Console.WriteLine("Please enter Age: ");
            intenteredAge = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine(strUsername);
            //Console.WriteLine(strPassword);
            //Console.WriteLine("Press enter to check if Username is correct");
            //Console.ReadLine();
            //Console.Clear();

            if (strUsername == strEnteredUsername && strPassword == strEnteredPassword && intenteredAge == iAge)

            {
                Console.WriteLine("Username is correct");
                Console.ReadLine();

                if (iAge < 16)
                {
                    Console.WriteLine("\nYou are too young to enroll");
                   
                }
                else
                {
                    Console.WriteLine("You are old enough to enroll");
                }

                Console.ReadLine();
            }

            else if (strUsername != strEnteredUsername)
            {
                Console.WriteLine("Username Incorrect");
            }

            else if (strPassword != strEnteredPassword)
            {
                Console.WriteLine("Username Password");
            }
            else
            {
                Console.WriteLine("Info Incorrect");
                Console.ReadLine();
            }
            
        }
    }
}

using System;

namespace WageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string strForename;
            string strSurname;
            int iAge;
            int iMenuChoice;
            double dHoursWork; //using d or str at front of variable allows you to easily identify id its a string or double etc
            double dHourRate = 0; //had to assign a value to these, didn't work if these were undefined
            double dWage = 0;

            Console.WriteLine("Please enter your Forename: "); //ask user for input
            strForename = Console.ReadLine(); //use readline to store user nput in variable

            Console.WriteLine("Please enter your Surname: ");
            strSurname = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");
            iAge = Convert.ToInt32(Console.ReadLine()); //convert users input (which is a string) to an integer

            //Console.WriteLine("\n Your name is: " + strForename + " " + strSurname + "\n Your age is: " + iAge);

            Console.Clear();
            Console.WriteLine("Welcome " + strForename + "!");

            Console.WriteLine("\nPlease choose from the following options: \n\n\t1. Calculate Wage \n\t2. Exit"); //if it is a long text, may need to put on seperate lines

            iMenuChoice = Convert.ToInt32(Console.ReadLine());

            if (iMenuChoice == 1)
            {
                Console.Clear();
                Console.WriteLine("Calculating wage");
                Console.Write("\nPlease enter how many hours you have worked this week: ");
                dHoursWork = Convert.ToDouble(Console.ReadLine());

                if(iAge >= 16 && iAge <= 17)
                {
                    dHourRate = 4.62;
                    dWage = dHourRate * dHoursWork; //caluculate variables
                }

                else if (iAge >= 18 && iAge <= 20)
                {
                    dHourRate = 6.56;
                    dWage = dHourRate * dHoursWork;
                }

                else if (iAge >= 21 && iAge <= 22)
                {
                    dHourRate = 8.36;
                    dWage = dHourRate * dHoursWork;
                }

                else if (iAge >= 23)
                {
                    dHourRate = 8.91;
                    dWage = dHourRate * dHoursWork;
                }

                else
                {
                    Console.WriteLine("\nInvalid Entry - Age entered must be over 16");
                    return;
                }

                Console.WriteLine("Your name is: " + strForename + " " + strSurname); //put the console print outside the individual if statements to make neater and reduce lines of code.
                Console.WriteLine("Your age is: " + iAge);
                Console.WriteLine("Your hourly rate is: " + dHourRate); //print out variables
                Console.WriteLine("Your Total weekly wage is: " + dWage);
            }
            
            else {
                Console.Clear();
                Console.WriteLine("Thank you for using this system.");
                Console.WriteLine("\nApplication will now exit on a key press...");
                 }

            

        }

    }
}
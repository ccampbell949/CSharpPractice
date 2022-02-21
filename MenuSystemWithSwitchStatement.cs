using System;

namespace MenuSystemWithSwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //show the main menu
            MainMenu();
        }

        private static void MainMenu()
        {
            //Display the main menu

            Console.WriteLine("Main Menu");
            Console.WriteLine("**************");
            Console.WriteLine();
            Console.WriteLine("1) Option 1");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) Option 3");
            Console.WriteLine("4) Exit");
            Console.WriteLine();
            Console.Write("Please choose an option from 1 - 4: ");

            //prmpt user and get input

            int userChoice = Convert.ToInt32(Console.ReadLine());

            //evaluate users choice

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("Menu Option 1 chosen");
                    break;
                case 2:
                    Console.WriteLine("Menu Option 2 chosen");
                    break;
                case 3:
                    Console.WriteLine("Menu Option 3 chosen");
                    break;
                case 4:
                    //Call Exit() procedure
                    //Exit()
                    break;

                default:
                    Console.WriteLine("Invalid Selection - Please choose an option from 1-4");
                    MainMenu(); //recursive call of main menu
                    break;
            }


        }
    }
}

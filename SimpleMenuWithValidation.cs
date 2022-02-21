using System;

namespace SimpleMenuWithValidation
{
    class Program
    {
        static void Main(string[] args)
        {

            //Call main menu
            MainMenu();
        }
            private static void MainMenu() 
            {

                try//Try-Catch to catch number format Exception, which may be thrown if user enters non-numeric
            
                {

                    {
                        //display main menu
                        Console.WriteLine("Main Menu");
                        Console.WriteLine("***************************");
                        Console.WriteLine("1) Option 1");
                        Console.WriteLine("2) Option 2");
                        Console.WriteLine("3) Option 3");
                        Console.WriteLine("4) Option 4");
                        Console.WriteLine("5) Exit");
                        Console.Write("Please select an option: ");

                        int iMenuChoice = Convert.ToInt32(Console.ReadLine());// read chosen option

                        if (iMenuChoice == 1)
                        {
                            Console.WriteLine("Menu option 1 chosen");
                            MainMenu();

                        }
                        else if (iMenuChoice == 2)
                        {
                            Console.WriteLine("Menu option 2 chosen");
                            MainMenu();
                        }
                        else if (iMenuChoice == 3)
                        {
                            Console.WriteLine("Menu option 3 chosen");
                            MainMenu();
                        }
                        else if (iMenuChoice == 4)
                        {
                            Console.WriteLine("Menu option 4 chosen");
                            MainMenu();
                        }
                        else if (iMenuChoice == 5)
                        {
                            //option to exit
                            //call the Exit() procedure
                            Exit();
                        }
                        else
                        {
                            //some other option
                            //Display error message and return menu

                            Console.WriteLine("Error: Invalid option, please try again");
                            MainMenu();
                        }

                    }
                }
                catch(FormatException f)
                {
                    //display error message
                    Console.WriteLine("Invalid Input - Please selct a number");
                    //call MainMenu again
                    MainMenu();                
                }

                

            }

        private static void Exit() //menu option 5
        {
            //prompt user for exit

            Console.WriteLine();
            Console.WriteLine("Are you sure you want to exit? y/n");

            string userResponse = Console.ReadLine().ToLower();


            //Validate users response. (I would do it like should be if equals "y" or "yes")

            if (userResponse.StartsWith("y")) //could also do an || userResponse.StartWith("Y") if you didnt convert to lower
            {
                //Exit application
                Environment.Exit(0);
            }
            else if (userResponse.StartsWith("n"))
            {
                //return to main menu
                MainMenu();
            }
            else
            {
                //display error message
                Console.WriteLine("Invalid Input");
                //call exit procedure recursively
                Exit();
            }
        }
        
    }
}

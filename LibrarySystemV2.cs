using System;

namespace LibrarySystemV2
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] strBookTitle = new string[3]; //could have a user input here to allow user to define array size

            int iArrayCounter = strBookTitle.Length; //make iarraycounter the same length as the array
            int iMenuchoice;

            do
            {
                Console.WriteLine("Please select from the following options:"); //user menu
                Console.WriteLine("1) Add books");
                Console.WriteLine("2) View Books");
                Console.WriteLine("3) Exit");

                iMenuchoice = Convert.ToInt32(Console.ReadLine());

                if (iMenuchoice == 1)
                {


                    for (int iLoopcounter = 0; iLoopcounter < iArrayCounter; iLoopcounter++) //(counter; condition; increment)
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter the book Title: ");
                        strBookTitle[iLoopcounter] = Console.ReadLine();

                        //Console.WriteLine("Current position: " + (iLoopcounter + 1));
                        //Console.WriteLine("Book stored at current position: " + strBookTitle[iLoopcounter]);


                    }

                }

                else if (iMenuchoice == 2)
                {
                    Console.Clear();

                    for (int iLoopCounter = 0; iLoopCounter < iArrayCounter; iLoopCounter++) //loop through and display names. Not the counter does not need defined beforehand and can be done in the brackets
                    {
                        Console.WriteLine("Book " + (iLoopCounter + 1) + " is " + strBookTitle[iLoopCounter]);
                    }
                }

                else if (iMenuchoice == 3)
                {
                    Console.WriteLine("Exiting programme");
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            } while (iMenuchoice < 4); //this could probably be changed for a better condition
    }


            
            




            

            //Console.WriteLine(strBookTitle[0]);
            //Console.WriteLine(strBookTitle[1]);
            //Console.WriteLine(strBookTitle[2]);

        
    }
}
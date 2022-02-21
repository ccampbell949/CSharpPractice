using System;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strBookTitle = new string[10];

            int iArrayCounter = 0;
            string strBook;
            int iTotalBooks = 0;
            int i;
            int iMenuchoice;


            

            //Console.WriteLine("Where do you want to save this book? (position 0-9");
            //iArrayCounter = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("What is the Book Title?");
            //strBookTitle[iArrayCounter] = Console.ReadLine();

            Console.WriteLine("Please choose from the following options: ");
            Console.WriteLine("1) Add Book");
            Console.WriteLine("2) View All books");
            Console.WriteLine("3) Exit");

            iMenuchoice = Convert.ToInt32(Console.ReadLine());



            if (iMenuchoice == 1)
            {

                Console.WriteLine("How many books would you like to enter?");
                iTotalBooks = Convert.ToInt32(Console.ReadLine());

                for (i = 0; i < iTotalBooks; i++)
                {
                    
                    Console.WriteLine("Where do you want to save book " + (i + 1));
                    iArrayCounter = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("What is the Book Title?");
                    strBookTitle[iArrayCounter] = Console.ReadLine();


                    //Console.WriteLine(strBookTitle[iArrayCounter]);
                }


            }
            
            else if (iMenuchoice == 2)
            {
                for (i = 0; i < iTotalBooks; i++)
                {
                    Console.WriteLine(strBookTitle[iArrayCounter]);
                }
            }
        }
    }
}

using System;

namespace IntroToVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Connor"; // string is required for text 
            int age = 31; // int is required for numbers

            // \n is for new line
            // \t is to tab across

            Console.WriteLine("Variables");
            Console.WriteLine();
            Console.WriteLine("\tUsername: " + name); //prints users name
            Console.WriteLine("\tAge: " + age);// prints users age
            Console.WriteLine("\n\nPress any key");
            Console.ReadLine();

            Console.Clear(); //clear console of previous info
            Console.WriteLine("New info...");

            name = "Gary";
            age = 25;
            Console.WriteLine("\n\tName: " + name);
            Console.WriteLine("\tAge: " + age);
            Console.WriteLine("\n\nPress any key");
            Console.ReadLine();
        }
    }
}

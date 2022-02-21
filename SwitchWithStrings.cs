using System;

namespace SwitchWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            GetDayofWeek();
        }

        private static void GetDayofWeek()
        {
            //read in a word corresponding to the day of the week

            //Read in a day of the week from user
            Console.Write("Please enter a day of the week: ");
            string DayofWeek = (Console.ReadLine()).ToLower();

            //evaluate entered day of week

            switch (DayofWeek)
            {
                case "monday":  //don't need curly braces for the switch statement
                    Console.WriteLine("Day 1");
                    GetDayofWeek();
                    break;
                case "tuesday":
                    Console.WriteLine("Day 2");
                    GetDayofWeek();
                    break;
                case "wednesday":
                    Console.WriteLine("Day 3");
                    GetDayofWeek();
                    break;
                case "thursday":
                    Console.WriteLine("Day 4");
                    GetDayofWeek();
                    break;
                case "friday":
                    Console.WriteLine("Day 5");
                    GetDayofWeek();
                    break;
                case "saturday":
                    Console.WriteLine("Day 6");
                    GetDayofWeek();
                    break;
                case "sunday":
                    Console.WriteLine("Day 7");
                    GetDayofWeek();
                    break;
                case "exit":
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input - Please try again");
                    GetDayofWeek();
                    break;
            }
        }
    }
}

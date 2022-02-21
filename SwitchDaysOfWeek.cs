using System;

namespace SwitchDaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            GetDayofWeek();
        }

        private static void GetDayofWeek()
        {
            //ask user to enter a number of the day of the week
            Console.Write("Please enter a number for the day of the week (1-7) or enter -99 to exit:");
            int dayofweek = Convert.ToInt32(Console.ReadLine());

            switch (dayofweek)
            {
                case -99:
                    Console.WriteLine("Exiting application - Goodbye!");
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    GetDayofWeek();
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    GetDayofWeek();
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    GetDayofWeek();
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    GetDayofWeek();
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    GetDayofWeek();
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    GetDayofWeek();
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    GetDayofWeek();
                    break;
                default:
                    Console.WriteLine("Invalid selection - please choose a number between 1-7");
                    GetDayofWeek();
                    break;
            }
        }
    }
}

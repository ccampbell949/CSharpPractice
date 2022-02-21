using System;

namespace ConversionFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //menu system for selecting which function you would like to carryout

           int iMenuchoice;
            
            do
            {
                

                Console.WriteLine("Please select from the following options: ");
                Console.WriteLine("1) Metres to Feet ");
                Console.WriteLine("2) Feet to Metres: ");
                Console.WriteLine("3) Miles to Kilometres ");
                Console.WriteLine("4) Kilometres to Miles: ");
                Console.WriteLine("5) Exit: ");

                iMenuchoice = Convert.ToInt32(Console.ReadLine());

                if (iMenuchoice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter Metres: ");
                    double metres = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Feet: " + MetresToFeet(metres));

                }
                if (iMenuchoice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter Feet: ");
                    double feet = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Metres " + FeetToMetres(feet));

                }
                if (iMenuchoice == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter Miles: ");
                    double miles = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Kilometres: " + MilesToKilometres(miles));

                }
                if (iMenuchoice == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter Kilometress: ");
                    double kilometres = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Miles: " + KilometresToMiles(kilometres));

                }

            } while (iMenuchoice != 5);

            //double feet = 20;
            //double miles = 100;
            //double kilometres = 200;

            ////Console.WriteLine("Feet: " + MetresToFeet(metres));
            //Console.WriteLine("Metres " + FeetToMetres(feet));
            //Console.WriteLine("Kilometres: " + MilesToKilometres(miles));
            //Console.WriteLine("Miles: " + KilometresToMiles(kilometres));

        }

        //Create function converting metres to feet
        private static double MetresToFeet(double n1)
        {
            //1 Meter = 3.2808399 Foot

            double result = n1 * 3.2808399;
            return result;
        }
        private static double FeetToMetres(double n1) //convert feet to metres
        {
            //1ft= 0.3048000m

            double result = n1 * 0.3048000; //can also just reverse the * and / when going between units
            return result;                  // e.g. n1 / 0.30480000
        }
        private static double MilesToKilometres(double n1) //coinvert miles to kilometres
        {
            //1mi = 1.609344km

            double result = n1 * 1.609344;
            return result;
        }

        private static double KilometresToMiles(double n1) //convert kilometres to miles
        {
            //1Km is equivalent to 0.6214 miles

            double result = n1 * 0.6214;
            return result;
        }
    }
}

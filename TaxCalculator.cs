using System;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //name of person
            //how much they earn
            // if statement for different tax bands

            string name = "Connor Campbell";
            double earnings = 35000;

            if (earnings <= 12570)
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("\nYour tax rate is 0%");
                Console.WriteLine("\nYour earnings before Tax = " + earnings); 
                double afterTax1 = (earnings * 1);
                Console.WriteLine("\nYour earnings after Tax = " + afterTax1);
                Console.ReadLine();
            }

            else if ((earnings >= 12571) && (earnings <= 50270))
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("\nYour tax rate is 20%");
                Console.WriteLine("\nYour earnings before Tax = " + earnings);
                double afterTax2 = (earnings * 0.8);
                Console.WriteLine("\nYour earnings after Tax = " + afterTax2);
                Console.ReadLine();
            }

            else if ((earnings >= 50271) && (earnings <= 150000))
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("\nYour tax rate is 40%");
                Console.WriteLine("\nYour earnings before Tax = " + earnings);
                double afterTax3 = (earnings * 0.6);
                Console.WriteLine("\nYour earnings after Tax = " + afterTax3);
                Console.ReadLine();
            }

             else if (earnings > 150000)
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("\nYour tax rate is 45%");
                Console.WriteLine("\nYour earnings before Tax = " + earnings);  //variables will only be changed when the if statement condition is met
                double afterTax4 = (earnings * 0.55);                           //thus the variable can be named the same thing in all the if statements
                Console.WriteLine("\nYour earnings after Tax = " + afterTax4);  //and then you can have the console write commands outside all of the if statements
                Console.ReadLine();                                             //and then print out the variable in the statement


            }

            else
                Console.WriteLine("Invalid Number");
        }
    }
}


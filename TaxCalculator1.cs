using System;

namespace TaxCalculator1
{
    class Program
    {
        static void Main(string[] args)
        {

            int income = 150000;
            double taxRate;
            double totalTax;
            string name = "Connor Campbell";
            double afterTax;

            if (income > 150000)
            {
                afterTax = 0.55;
                taxRate = (1 - afterTax) * 100; //need to add afterTax variable oto all if statements to see if that works - doesn't currently run
            }
            else if (income >= 50271 && income <= 150000)
            {
                taxRate = 0.6;
            }
            else if (income >= 12570 && income <= 50270)
            {
                taxRate = 0.8;
            }
            else
            {
                taxRate = 0.0;
            }
            Console.WriteLine("\nName: " + name);
            Console.WriteLine("Your income is: " + income);
            Console.WriteLine("Your tax rate is: " + taxRate);
            totalTax = income * afterTax;
            Console.WriteLine("Total payable tax: " + totalTax);

           
        }
    }
}

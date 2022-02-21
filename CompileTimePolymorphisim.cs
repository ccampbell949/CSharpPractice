using System;

namespace CompileTimePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an adder object
            Adder a = new Adder();

            //define some variables to use in calculations
            int number1 = 5, number2 = 8, number3 = 12;
            double double1 = 8.3, double2 = 6.4, double3 = 5.9;

            //call the Add() function using different inputs

            Console.WriteLine("number1 + number 2 = " + a.Add(number1, number2));
            Console.WriteLine("number1 + number2 + number 3 = " + a.Add(number1, number2, number3));
            Console.Write("double1 + double2 = " + a.Add(double1, double2));
            Console.WriteLine("double1 + double2 + double3 = " + a.Add(double1, double2, double3));

            //the code knows which function to use based on the inout parameters given

            //Overloaded method - same name as other method but different method signature
        }
    }
}

using System;

namespace CarsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strCars = new string[5];

            strCars[0] = "Honda";
            strCars[1] = "Nissan";
            strCars[2] = "VW";
            strCars[3] = "MINI";
            strCars[4] = "BMW";

            Console.WriteLine("The 1st car in this list is: " + strCars[0]);
            Console.WriteLine("The 2nd car in this list is: " + strCars[1]);
            Console.WriteLine("The 3rd car in this list is: " + strCars[2]);
            Console.WriteLine("The 4th car in this list is: " + strCars[3]);
            Console.WriteLine("The 5th car in this list is: " + strCars[4]);
        }
    }
}

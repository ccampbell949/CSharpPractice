using System;

namespace AreaCircle //changed this to area of a square
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables and dims for square
            //number1 and number2
            double number1 = 3; //height
            double number2 = 6; //length
            double number3 = 4; //radius
          
            Console.WriteLine("The area of the square is: " + AreaSquare(number1)); //number 1 as the input variables
            Console.WriteLine("The area of the circle is: " + AreaCircle(number3)); //number3 is the radius
            Console.WriteLine("The area of the Triangle is: " + AreaTriangle(number1, number2));
            Console.WriteLine("The area of the Rectangle is: " + AreaRectangle(number1, number2)); //same formula as square
        }



        private static double AreaSquare(double n1) //define function which takes input parameters
        {
            double area = n1 * n1; //formula for area of square
            return area; //return area of the square - square only requires 1 inout as sides are equal length
        }
        private static double AreaCircle(double n1) //define function which takes input parameters
        {
            double area = Math.PI * (Math.Pow(n1, 2)); //formula for area of circle

            return area; //return area of the circle

        }
        private static double AreaTriangle(double n1, double n2) //define function which takes input parameters
        {
            double area = 0.5 * (n1 * n2); //formula for area of triangle
            return area; //return area of the circle

        }
        private static double AreaRectangle(double n1, double n2) //define function which takes input parameters
        {
            double area = n1 * n2; //formula for area of rectangle
            return area; //return area of the circle
        }
}

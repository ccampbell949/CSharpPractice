using System;

namespace ShapeCalculatorOOPWalkthrough
{
    class ShapeCalculatorUI
    {
        static void Main(string[] args)
        {
            //Declare variables to store test values for each shape

            double squareSide = 5;
            double circleRadius = 3.5;
            double Width = 8;
            double Height = 4;

            //create objects of each shape for testing
            Circle myCircle = new Circle(circleRadius);
            Triangle myTriangle = new Triangle(Width, Height);
            Square mySquare = new Square(squareSide);
            Rectangle myRectangle = new Rectangle(Width, Height);

            mySquare.Side = 8;

            //Access Area property of each shape, to get area
            Console.WriteLine("Area of Circle: " + myCircle.Area.ToString("0.0")); //needs double quotes as converting to a string
            Console.WriteLine("Area of Rectangle: " + myRectangle.Area.ToString("0.0"));
            Console.WriteLine("Area of Triangle: " + myTriangle.Area.ToString("0.0"));
            Console.WriteLine("Area of Square: " + mySquare.Area.ToString("0.0"));
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculatorOOPWalkthrough
{
    public class Square
    {
        //this Class is used to create a Square object for calculating it's area

        //variable to store side length

        private double side;

        //Public properties

        public double Side
        {
            set //dont need a getter
            {
                side = value;
            }
        }

        public double Area
        {
            get //dont need a setter
            {
                return Math.Pow(side, 2);
            }
        }

        //Parameterised constructor
        public Square(double s)
        {
            side = s;
        }
    }
}

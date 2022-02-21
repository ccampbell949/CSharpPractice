using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculatorOOPWalkthrough
{
    public class Circle
    {
        //this class is used to create an instance of a circle object to calculate its area

        //private variable to store radius
        private double radius;


        //public property

        public double Radius
        {
            set
            {
                radius = value;
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }

        //constructor
        public Circle(double r)
        {
            //assign parameter value to radius

            radius = r;
        }
    }
}

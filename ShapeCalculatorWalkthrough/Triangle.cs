using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculatorOOPWalkthrough
{
    public class Triangle
    {
        //this class may be used to create an instance of a triangle object to calculate its area

        //variables to store width and height
        private double width;
        private double height;

        //public properties

        public double Width
        {
            set
            {
                width = value;
            }
        }
        public double Height
        {
            set
            {
                width = value;
            }
        }

        public double Area
        {
            get
            {
                return 0.5 * width * height;
            }
        }

        //constructor

        public Triangle(double w, double h)
        {
            //assign parameter values to width and height
            width = w;
            height = h;


        }

    }
}

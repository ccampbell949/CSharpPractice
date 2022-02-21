using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculatorOOPWalkthrough
{
    public class Rectangle
    {
        //this class may be used to create an instance of a rectangle object to calculate its area

        //variables to store width and height
        private double width;
        private double height;

        //public properties

        public double Width
        {
            set //don't need a getters as we are not retreiveing the width and height
            {
                width = value; //setting a public property Width as equal to the value of the parameter
            }                   //given to the Rectangle 
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
                return width * height;
            }
        }

        //Parameterised constructor

        public Rectangle(double w, double h)
        {
            //assign parameter values to width and height
            width = w;
            height = h;
        }
    }
}

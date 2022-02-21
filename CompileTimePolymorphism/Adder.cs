using System;
using System.Collections.Generic;
using System.Text;

namespace CompileTimePolymorphism
{
    class Adder
    {
        //simple class for adding numbers
        //it uses compile time polymorphism

        public int Add(int n1, int n2)
        {
            //add 2 integers
            return n1 + n2;
        }

        public double Add(double n1, double n2) //can have the same name if it has different input types or number of parameters
        {
            //add 2 doubles
            return n1 + n2;
        }

        public int Add(int n1, int n2, int n3)
        {
            //add 3 integers
            return n1 + n2 + n3;
        }

        public double Add(double n1, double n2, double n3)
        {
            //add 3 doubles
            return n1 + n2 + n3;
        }
    }
}

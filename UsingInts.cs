using System;

namespace UsingInts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with Ints");

            #region Variables

            //Variables

            int iNumber1 = 5;
            int iNumber2 = 10;
            int iAnswer;

            #endregion

            #region Pass1
            Console.WriteLine("Addition - ");
            iAnswer = iNumber1 + iNumber2;
            Console.WriteLine(iNumber1 + " + " + iNumber2 + " = " + iAnswer);
            Console.ReadLine();

            Console.WriteLine("Subtraction - ");
            iAnswer = iNumber1 - iNumber2;
            Console.WriteLine(iNumber1 + " - " + iNumber2 + " = " + iAnswer);
            Console.ReadLine();

            Console.WriteLine("Division - ");
            iAnswer = iNumber2 / iNumber1;
            Console.WriteLine(iNumber1 + " / " + iNumber2 + " = " + iAnswer);
            Console.ReadLine();

            Console.WriteLine("Multiplication - ");
            iAnswer = iNumber1 * iNumber2;
            Console.WriteLine(iNumber1 + " * " + iNumber2 + " = " + iAnswer);
            Console.ReadLine();
            #endregion

            iNumber1 = 8;
            iNumber2 = 2;

            #region Pass2
            Console.WriteLine("Addition - ");
            iAnswer = iNumber1 + iNumber2;
            Console.WriteLine(iNumber1 + " + " + iNumber2 + " = " + iAnswer);
            Console.ReadLine();

            Console.WriteLine("Subtraction - ");
            iAnswer = iNumber1 - iNumber2;
            Console.WriteLine(iNumber1 + " - " + iNumber2 + " = " + iAnswer);
            Console.ReadLine();

            Console.WriteLine("Division - ");
            iAnswer = iNumber2 / iNumber1;
            Console.WriteLine(iNumber1 + " / " + iNumber2 + " = " + iAnswer);
            Console.ReadLine();

            Console.WriteLine("Multiplication - ");
            iAnswer = iNumber1 * iNumber2;
            Console.WriteLine(iNumber1 + " * " + iNumber2 + " = " + iAnswer);
            Console.ReadLine();

            #endregion
        }
    }
}

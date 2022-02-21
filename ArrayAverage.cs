using System;

namespace ArrayAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare array for testing
            int[] testArray = { 5, 3, 1, 9, 7 }; //undefined arrays are like - int[] test = new int[5] i.e array of size 5

            //declare variable to store the average
            int arrayAverage;

            //calculate and display average

            arrayAverage = ArrayAverage(testArray);
            Console.WriteLine("The Array average is: " + arrayAverage);
        }

        private static int ArrayAverage(int[] input)
        {
        //declare a variable to store the average
            int average;

        //Get the sum total of the array items

            int sum = 0;
            // use a for loop to iterate the array

            for (int counter = 0; counter < input.Length; counter++)
            {
                sum += input[counter];
                // this is shorthand for sum = sum + inout[counter]
            }

            //get the average
            average = sum / input.Length;
            return average;

        }
    }
}

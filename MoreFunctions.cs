using System;

namespace MoreFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a variable to store the result
            int result;
            //read in 2 numbers

            Console.WriteLine("Please enter number 1: ");

            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter number 2: ");

            int number2 = Convert.ToInt32(Console.ReadLine());

            //using the Add function to get the result

            result = Add(number1, number2);
            Console.WriteLine("The result is: " + result);

            // using the AddTwoNumbers procedure to get the result
            Console.WriteLine("Result from procedure is: ");
            //Call procedure
            AddTwoNumbers(number1, number2);
        }

        //create a function to add 2 numbers

        private static int Add(int n1, int n2)
        {
            int result = n1 + n2;
            return result; //this stores the result in order to use the value without having to print out the value
        }

        private static void AddTwoNumbers(int n1, int n2)
        {
            //using a proceduire to achieve the same thing
            int result = n1 + n2; //cannot use return in this case as the rturn is stated as "void". Void data type

            //need to print out the result
            Console.WriteLine(result);

        }
    }
}

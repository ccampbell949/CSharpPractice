using System;

namespace SomeMoreFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //First function: get word length
            string testword = "Bangor";
            Console.WriteLine("Word length: " + WordLength(testword));

            //Get Array length
            string[] testStudentList = {"Jack", "David", "Connor"};
            Console.WriteLine("Array length is: " + ArrayLength(testStudentList));

            //Get Remainder
            int n1 = 5, n2 = 3;
            Console.WriteLine("Remainder is: " + Remainder(n1, n2));


        }

        //Function to get the length of a word
        private static int WordLength(String word)     //get and return length of a word
        {

            int l = word.Length;
            return l;

          
        }

        //Function to get the length of an array of strings
        private static int ArrayLength(string[] a)
        {
            //Get and return array length

            int l = a.Length;
            return l;
        }

        //Function to get the remainder of a division
        private static int Remainder(int n1, int n2)
        {

            // Get the reaminder of n1 / n2
            int r = n1 % n2;
            return r; //e.g. 5 / 2 will return value 1
        }
    }
}

using System;

namespace GetLarger
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 10;
            int larger = GetLarger(number1, number2);

            Console.WriteLine("The larger number is: " + larger);
        }

        //function to accept in 2 parameters which will check to see which is bigger

        private static int GetLarger(int n1, int n2) 
        {
            if (n1 > n2)
            {
                
                return  n1;
            }

            else if (n2 > n1)
            {
               
                return n2;
            }
            else
            {
                
                return 0;
            }
        }
    }
}

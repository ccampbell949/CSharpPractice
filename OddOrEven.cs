using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
           //can declare 2 variables such as od number and even number or hard code as done here
            

           bool result = OddOrEven(7);
            if (result == true)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("The number is Odd");
            }
        }


        //take input numbers
        //Divide input number by 2 or work out modulus
        //if modulus is DivideByZeroException after dividing by 2, its even, otherwise the number is Odd

        private static bool OddOrEven(int number) //have to have bool in ititial line as thats what we want the formula to return
        {
                    
            //declare variables
            
            int remainder = number % 2;

            if(remainder != 0)
            {
                //Number is not even
                return false;
               
                
                    
            }

            else
            {
                //Number is Even
                return true;
              
            }


        
        }
    }
}

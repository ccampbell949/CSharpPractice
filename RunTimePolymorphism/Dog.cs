using System;
using System.Collections.Generic;
using System.Text;

namespace RunTimePolymorphism
{
    public class Dog : Animal
    {
        //the Dog class inherits from the Animal class and will override the MakeSound procedure with
        //it's own implementation

        //Override the MakeSound() procedure
        public override void MakeSound()
        {
            //Cats own implementation of MakeSound()
            Console.WriteLine("Woof");
        }
    }
}

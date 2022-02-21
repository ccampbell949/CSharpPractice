using System;
using System.Collections.Generic;
using System.Text;

namespace RunTimePolymorphism
{
    public class Animal
    {
        //this class is used to demonstrate Runtime polymorphism through method overriding and inheritance
        public void Eat()
        {
            //generic Eat() procedure
            Console.WriteLine("I am eating.");
            
        }
        public void Sleep()
        {
            //generic Sleep() procedure
            Console.WriteLine("I am sleeping");

        }

        public virtual void MakeSound()
        {
            //General MakeSound() procedure
            Console.WriteLine("I make noise");
        }
    }

    
}

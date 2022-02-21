using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionDemonstration
{
    public abstract class AbstractAnimal //cannot instantiate an abstract class, but can inherit from it
    {
        //abstractanimal is an abstract class. It will contain 1 or nore abstract methods and it can not
        //be instantiated. Instead we must inherit from it

        //Eat method

        public void Eat()
        {
            //eat method for animals
            Console.WriteLine("I am eating");
        }

        public void Sleep()
        {
            //sleep method for animals
            Console.WriteLine("I am sleeping");
        }

        public abstract void MakeSound();
        
    }
}

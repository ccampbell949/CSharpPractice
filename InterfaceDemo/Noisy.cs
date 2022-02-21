using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    public interface Noisy
    {
        //this is an interface.
        //Interfaces must not implement any methods (functions)

        public abstract void MakeSound(); //the makesound procedure for making sounds

        //Animal specific sound procedures
        public abstract void Bark();
        public abstract void Meow();
        public abstract void Squeak();

    }
}

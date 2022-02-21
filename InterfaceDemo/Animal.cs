using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    public class Animal : Noisy
    {
        //Animal needs to implement ALL noisy procedures, as they are currently undefined and not implemented
        public virtual void MakeSound()
        {
            //empty method
        }

        //implement animal specific procedures
        public virtual void Bark()
        {
            //Empty method
        }

        public virtual void Squeak()
        {
            //Empty method
        }

        public virtual void Meow()
        {
            //empty method
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    public class Mouse : Animal
    {
        //Mouse is inheriting from Animal, which also inherits from Noisy.
        //we can provide implementations of the specific noise making procedures for cat.

        //MakeSound()
        public override void MakeSound()
        {
            //output the Cat's sound
            Console.WriteLine("Squeak");
        }

        public override void Squeak()
        {
            //call MakeSound() as it's the same as above
            MakeSound();
        }
    }
}

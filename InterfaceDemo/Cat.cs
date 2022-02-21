using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    public class Cat : Animal
    {
        //Cat is inheriting from Animal, which also inherits from Noisy.
        //we can provide implementations of the specific noise making procedures for cat.

        //MakeSound()

        public override void MakeSound()
        {
            //output the Cat's sound
            Console.WriteLine("Meow");
        }

        public override void Meow()
        {
            //call MakeSound() as it's the same as above
            MakeSound();
        }
    }
}

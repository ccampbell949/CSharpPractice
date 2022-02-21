using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionDemonstration
{
    public class Dog : AbstractAnimal
    {
        //Dog is inheriting from AbstractAnimal.
        //in order to do this, the class must implement all abstract methods

        //implement the MakeSound() procedure

        public override void MakeSound()
        {
            //output a dog sound
            Console.WriteLine("Woof");
        }
    }
}

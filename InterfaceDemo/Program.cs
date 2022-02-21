using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program demos the use of Interface

            //cannot instantiate noisy as it is abstract
            //Noisy noisyThing = new Noisy(); wont work

            //Create some animals
            Cat myCat = new Cat();
            Mouse myMouse = new Mouse();
            Animal anAnimal = new Animal();
            NoisyCat noisyCat = new NoisyCat();

            //Calling the make sound procedure
            Console.WriteLine("Cat: ");
            myCat.MakeSound();

            Console.WriteLine("Mouse: "); //havent defined or implemented code for this sound so shouldnt do anything
            myMouse.MakeSound();

            Console.WriteLine("Animal: ");
            anAnimal.MakeSound();


            //Calling the Meow() procedure
            Console.WriteLine("Cat: ");
            myCat.Meow();

            Console.WriteLine("Mouse: "); //havent defined or implemented code for this sound so shouldnt do anything
            myMouse.Meow();

            Console.WriteLine("Animal: ");
            anAnimal.Meow();

            //Calling the Squeak() procedure
            Console.WriteLine("Cat: ");
            myCat.Squeak();

            Console.WriteLine("Mouse: "); //havent defined or implemented code for this sound so shouldnt do anything
            myMouse.Squeak();

            Console.WriteLine("Animal: ");
            anAnimal.Squeak();

            //calling the noise making procedure in our NoisyCat

            Console.WriteLine("NoisyCat MakeSound(): ");
            noisyCat.MakeSound();

            Console.WriteLine("NoisyCat Meow(): ");
            noisyCat.Meow();

            //The following procedure should do nothing
            Console.WriteLine("NoisyCat Bark(): ");
            noisyCat.Bark();

            //The following procedure should do nothing
            Console.WriteLine("NoisyCat Squeak(): ");
            noisyCat.Squeak();
        }
    }
}


//overridden method is args method from the parent class overridden by the child implementation

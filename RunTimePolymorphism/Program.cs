using System;

namespace RunTimePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Animal objects
            Animal anAnimal = new Animal();
            Cat myCat = new Cat();
            Dog myDog = new Dog();

            //Eat proceudre call
            anAnimal.Eat();
            myCat.Eat();
            myDog.Eat();

            //sleep procedure call

            anAnimal.Sleep();
            myCat.Sleep();
            myDog.Sleep();

            //Make sound procedure call
            anAnimal.MakeSound(); //generic make sound
            myCat.MakeSound(); //cat specific sound
            myDog.MakeSound();//dog specific sound
        }
    }
}

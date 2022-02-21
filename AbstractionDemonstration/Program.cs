using System;

namespace AbstractionDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo of how Abstract classes may be implemented

            //create our animals
            Cat myCat = new Cat();
            Dog myDog = new Dog();

            //output Eat()

            myCat.Eat();
            myDog.Eat();

            //output sleep
            myCat.Sleep();
            myDog.Sleep();

            //output makesound()
            myCat.MakeSound();
            myDog.MakeSound();
        }
    }
}
//cannot instantiate an abstract class because there is information missing from it (the abstract method)

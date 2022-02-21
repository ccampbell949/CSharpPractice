using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    public class NoisyCat : Noisy
    {
        //NoisyCat directly implements Noisy Interface, so the class MUST implement ALL Noisy procedures
        
        //Makesound
        public void MakeSound()
        {
            //output cats sound
            Console.WriteLine("Meow");
        }

        public void Bark()
        {
            //cats dont bark but we still need to implement the procedure and leave it empty
        }

        public void Squeak()
        {
            //cats dont squeak but we still need to implement the procedure and leave it empty
        }

        public void Meow()
        {
            //Call MakeSound() to display meow
            MakeSound();
        }
    }
}

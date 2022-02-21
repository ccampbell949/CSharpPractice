using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Store a grade
            // store a student name

            string name = "Connor Campbell";
            int grade = 44;

            if (grade >= 75)
            {
                Console.WriteLine(name+ " You got an A!");
                Console.ReadLine();
            }
            else if (grade >= 65)
            {
                Console.WriteLine(name + " You got an B!");
                Console.ReadLine();
            }
            else if(grade >= 55)
            {
                Console.WriteLine(name + " You got an C!");
                Console.ReadLine();
            }

            else if (grade >= 45)
            {
                Console.WriteLine(name + " You got an D!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine(name + " You failed");
                Console.ReadLine();
            }


        }
    }
}

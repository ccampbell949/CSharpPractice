using System;

namespace GradeCalculatorV2
{
    class Program
    {


        //Bangor Academy have requested a console application that will allow them to record the grades for 20 students in three different subjects.The system should:

        //Calculate the average grade that a student achieves.
        //Store the student with the highest grade out of the 20 students.


        static void Main(string[] args)
        {

            //Ask user to enter name 
            //ask user to enter grade level
            //sort array by largest first//dispaly leaderboard
            //menu to see all results
            //do while loop

            //Variables
            string strStudentname;
            int iGrade;
            int iMenuchoice;
            
            
            string[] strStudents = new string[20];
            int[] strGrades1 = new int[20];
            int[] strGrades2 = new int[20];
            int[] strGrades3 = new int[20];
            double[] dAverageGrade = new double[20];
            double[] dSortedAverage = new double[20];
            string strTopStudent = "";
            double dHighestGrade = 0;

            //need string for name of highest student
            //need double for highest grade

            do
            {

                Console.WriteLine("Please select from the below options: ");
                Console.WriteLine("1) Add Student");
                Console.WriteLine("2) View Highest Grade");
                Console.WriteLine("3) Exit");

                iMenuchoice = Convert.ToInt32(Console.ReadLine());


                if (iMenuchoice == 1)
                {

                    for (int iloopcounter = 0; iloopcounter < strStudents.Length; iloopcounter++) //could store the .length as iArray counter variable
                    {



                        Console.Clear();
                        Console.WriteLine("Please enter the student " + (iloopcounter + 1) + " name");
                        strStudents[iloopcounter] = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine("Please enter Students first grade: ");
                        strGrades1[iloopcounter] = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine("Please enter Students second grade: ");
                        strGrades2[iloopcounter] = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine("Please enter Students third grade: ");
                        strGrades3[iloopcounter] = Convert.ToInt32(Console.ReadLine());

                        

                        //Console.WriteLine("Would you Like to enter another student?  y/n");
                        //string answer = Console.ReadLine().ToLower();
                        //if (answer == "n" || answer == "no")
                        //{
                        //    break;
                        //}
                        //else if (answer == "yes" || answer == "y")
                        //{
                        //    continue;
                        //}

                        //this code works, but then breaks the highest score?


                        

                        dAverageGrade[iloopcounter] = (strGrades1[iloopcounter] + strGrades2[iloopcounter] + strGrades3[iloopcounter]) / 3;

                        if (dAverageGrade[iloopcounter] > dHighestGrade)
                        {
                            dHighestGrade = dAverageGrade[iloopcounter];
                            strTopStudent = strStudents[iloopcounter];
                        }

                    }
                }

                else if (iMenuchoice == 2)
                {
                    //View leaderboard of averages
                    //print out names along with average grade
                    //also sort by largest first - array.sort

                    //calculate average

                    //for(int iloopcounter = 0; iloopcounter < strStudents.Length; iloopcounter++)
                    //{


                    //Calculate student averages and store in new array

                    //Console.WriteLine("\nGrade Leaderboard: ");

                    //for (int iloopcounter = 0; iloopcounter < strStudents.Length; iloopcounter++)
                    //{

                    //    Console.WriteLine(dAverageGrade[iloopcounter]);


                    //}

                    Console.WriteLine("\nThe top student is: " + strTopStudent + " with the highest average of: " + dHighestGrade);



                }

                else if (iMenuchoice == 3)
                {
                    Console.WriteLine("Now exiting: ");
                    Console.WriteLine("Press any key to exit: ");
                    Environment.Exit(0);
                }


            } while (iMenuchoice != 3);




        }
    }
}

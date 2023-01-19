//Author: Pedro Nader
//This code was written as a deliverable for the ISM 4300 class
//This is a simple grade calculator

//The first thing is to define the namspace and the class
using System;

    namespace deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Try catch to avoid bad inputs
            try
            {
                //Prompt the user to enter a grade and assign the value to a variable
                Console.WriteLine("Enter what grade you think you will get in this class: ");
                int grade = int.Parse(Console.ReadLine());


                //The all the if statements bellow serve to print out the correct Letter grade
                //The reason why I am going up is because the code is read from the bottem up, so if one of the 'If' statements is true, it will break all the others
                //No need to define an interval, just stopping points.
                if (grade < 60)
                {
                    Console.WriteLine("Your Letter Grade is F");
                    Console.ReadKey(true);
                }
                else if (grade < 70)
                {
                    Console.WriteLine("Your Letter Grade is D");
                    Console.ReadKey(true);
                }
                else if (grade < 80)
                {
                    Console.WriteLine("Your Letter Grade is C");
                    Console.ReadKey(true);
                }
                else if (grade < 90)
                {
                    Console.WriteLine("Your Letter Grade is B");
                    Console.ReadKey(true);
                }
                //If the score is not under 90 and it does not fit any of the above criteria, it has to be an A
                else
                {
                    Console.WriteLine("Your Letter Grade is A");
                    Console.ReadKey(true);
                }

            }
            //Printing user friendly message to prevent future errors
            catch
            {
                Console.WriteLine("Pleae enter an integer between 0-100");
            }

        }
    }
}
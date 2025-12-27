using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ControlFlowExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Write a program and ask the user to enter a number. The number should be between 1 to 10.
            //If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
            Console.WriteLine("Enter a number between 1 and 10:");
            int exercise1Number = Convert.ToInt32(Console.ReadLine());
            if(exercise1Number > 1 && exercise1Number < 10)
            {
                Console.WriteLine("You've entered a Valid number");
            }
            else
            {
                Console.WriteLine("You've entered an Invalid number");
            }

            Console.WriteLine();

            //2) Write a program which takes two numbers from the console and displays the maximum of the two.
            Console.WriteLine("Enter a number");
            int exercise2Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int exercise2Number2 = Convert.ToInt32(Console.ReadLine());
            if (exercise2Number1 > exercise2Number2)
            {
                Console.WriteLine(string.Format("{0} is the larger of the two", exercise2Number1));
            }
            else if (exercise2Number1 < exercise2Number2)
            {
                Console.WriteLine(string.Format("{0} is the larger of the two", exercise2Number2));
            }
            else
            {
                Console.WriteLine("The two numbers are the same"); ;
            }

            Console.WriteLine();

            //3) Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
            Console.WriteLine("Enter the width of the image");
            int exercise3Width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of the image");
            int exercise3Height = Convert.ToInt32(Console.ReadLine());
            if(exercise3Width > exercise3Height)
            {
                Console.WriteLine("The image has landscape orientation");
            }
            else if(exercise3Width < exercise3Height)
            {
                Console.WriteLine("The image has portrait orientation");
            }
            else
            {
                Console.WriteLine("The image is a perfect square");
            }

            Console.WriteLine();

            //4) Write a program that asks the user to enter the speed limit.
            //Once set, the program asks for the speed of a car.
            //If the user enters a value less than the speed limit, program should display Ok on the console.
            //If the value is above the speed limit, the program should calculate the number of demerit points.
            //For every 5km / hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
            //If the number of demerit points is above 12, the program should display License Suspended.
            Console.WriteLine("Enter the speed limit of the road:");
            int exercise4SpeedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the speed of the car:");
            int exercise4VehicleSpeed = Convert.ToInt32(Console.ReadLine());
            if(exercise4VehicleSpeed < exercise4SpeedLimit)
            {
                Console.WriteLine("Ok. You're free to go.");
            }
            else
            {
                int exercise4Demerits = Convert.ToInt32(Math.Ceiling((float) (exercise4VehicleSpeed - exercise4SpeedLimit) / (float) 5));
                Console.WriteLine(string.Format("{0} demerit points have been added to your license", exercise4Demerits));
                if(exercise4Demerits > 12)
                {
                    Console.WriteLine("You're license has been suspended");
                }
            }
        }
    }
}
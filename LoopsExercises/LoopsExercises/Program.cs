using System.Random;

namespace LoopExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
            int exercise1DivisibleBy3 = 0;
            for (int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    exercise1DivisibleBy3++;
                }
            }
            Console.WriteLine(string.Format("There are {0} numbers between 1 and 100 that are divisible by 3", exercise1DivisibleBy3));

            Console.WriteLine();

            //2) Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
            int exercise2Total = 0;
            while (true)
            {
                Console.WriteLine("Enter any number. Enter \"Ok\" to exit.");
                string? exercise2Input = Console.ReadLine();
                if(exercise2Input != "Ok")
                {
                    exercise2Total += Convert.ToInt32(exercise2Input);
                    continue;
                }
                break;
            }
            Console.WriteLine(string.Format("Exercise 2 Total: {0}", exercise2Total));

            //3) Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
            //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            int exercise3Factorial = 1;
            int exercise3Input = Convert.ToInt32(Console.ReadLine());
            for(int i = exercise3Input; i > 0; i--)
            {
                exercise3Factorial *= i;
            }
            Console.WriteLine(string.Format("{0}! = {1}", exercise3Input, exercise3Factorial));

            //4) Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
            //If the user guesses the number, display “You won"; otherwise, display “You lost".
            Random random = new Random();
            int exercise4Random = random.Next(1, 10);
            int exercise4Chances = 4;
            Console.WriteLine("Try to guess the random number:");
            while(exercise4Chances > 0)
            {
                int exercise4Guess = Convert.ToInt32(Console.ReadLine());
                if(exercise4Guess == exercise4Random)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                exercise4Chances -= 1;
                if(exercise4Chances <= 0)
                {
                    Console.WriteLine("You lost");
                    break;
                }
            }

            //5) Write a program and ask the user to enter a series of numbers separated by comma.
            //Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
            Console.WriteLine("Enter a series of numbers separated by commas");
            string? exercise5SeriesInput = Console.ReadLine();
            string[] exercise5Series = exercise5SeriesInput.Split(',');
            int exercise5Max = 0;
            foreach(string number in exercise5Series)
            {
                if(Convert.ToInt32(number) > exercise5Max)
                {
                    exercise5Max = Convert.ToInt32(number);
                }
            }
            Console.WriteLine(string.Format("The maximum of all numbers entered is {0}", exercise5Max));
        }
    }
}
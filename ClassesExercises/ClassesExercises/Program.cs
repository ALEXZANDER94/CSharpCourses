using System;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should provide two methods: Start and Stop.We call the start method first, and the stop method next.
            // Then we ask the stopwatch about the duration between start and stop. Duration should be a value in TimeSpan.Display the duration on the console.
            // We should also be able to use a stopwatch multiple times.So we may start and stop it and then start and stop it again. Make sure the duration value each time is calculated properly.
            // We should not be able to start a stopwatch twice in a row(because that may overwrite the initial start time). So the class should throw an InvalidOperationException if its started twice
            StringBuilder exercise1Menu = new StringBuilder();
            string? exercise1Choice = null;
            string[] validChoices = new string[] { "0", "1", "2", "3" };
            Stopwatch stopwatch = new Stopwatch();
            exercise1Menu
                .Append('=', 35)
                .AppendLine()
                .AppendLine("1) Start the stopwatch.")
                .AppendLine("2) Stop the stopwatch.")
                .AppendLine("3) Show the Current Stopwatch time.")
                .AppendLine("0) Quit.")
                .Append('=', 35);
            do
            {
                Console.WriteLine(exercise1Menu);
                Console.Write("Please make a choice: ");
                exercise1Choice = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(exercise1Choice) || !validChoices.Contains(exercise1Choice))
                {
                    Console.WriteLine("Invalid choice");
                }
                else
                {
                    // check the choice and run the appropriate method
                    switch (exercise1Choice)
                    {
                        case "0":
                            stopwatch.Stop();
                            Console.Clear();
                            Console.WriteLine("Goodbye!");
                            break;
                        case "1":
                            stopwatch.Start();
                            break;
                        case "2":
                            stopwatch.Stop();
                            break;
                        case "3":
                            stopwatch.ShowTime();
                            break;
                    }
                }

            } while (exercise1Choice != "0");

            Console.WriteLine();
            Console.Clear();

            // 2) Design a class called Post. This class models a StackOverflow post. It should have properties for title, description and the date / time it was created. We should be able to up - vote or down - vote
            // a post.We should also be able to see the current vote value.In the main method, create a post, up - vote and down - vote it a few times and then display the the current vote value.
            // In this exercise, you will learn that a StackOverflow post should provide methods for up - voting and down - voting.You should not give the ability to set the Vote property from the outside,
            // because otherwise, you may accidentally change the votes of a class to 0 or to a random number.And this is how we create bugs in our programs. The class should always protect its
            // state and hide its implementation detail

            StringBuilder exercise2Menu = new StringBuilder();
            string? exercise2Choice = null;
            Post post = new Post();
            exercise2Menu
                .Append('=', 35)
                .AppendLine()
                .AppendLine("1) View the post.")
                .AppendLine("2) Upvote the post.")
                .AppendLine("3) Downvote the post.")
                .AppendLine("0) Quit.")
                .Append('=', 35);
            do
            {
                Console.WriteLine(exercise2Menu);
                Console.Write("Please make a choice: ");
                exercise2Choice = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(exercise2Choice) || !validChoices.Contains(exercise2Choice))
                {
                    Console.WriteLine("Invalid choice");
                }
                else
                {
                    // check the choice and run the appropriate method
                    switch (exercise2Choice)
                    {
                        case "0":
                            Console.Clear();
                            Console.WriteLine("Goodbye!");
                            break;
                        case "1":
                            post.Summary();
                            break;
                        case "2":
                            post.Upvote();
                            break;
                        case "3":
                            post.Downvote();
                            break;
                    }
                }

            } while (exercise2Choice != "0");
        }
    }
}

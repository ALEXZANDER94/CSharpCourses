using System;
using System.Text;
using System.Threading;

namespace InheritanceExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] validChoices = new string[] { "0", "1", "2", "3" };
            // 1) A Stack is a data structure for storing a list of elements in a LIFO (last in, first out) fashion.
            // Design a class called Stack with three methods: Push, Pop, Clear
            StringBuilder exercise1Menu = new StringBuilder();
            Stack exercise1Stack = new Stack();
            exercise1Menu
                .Append('=', 50)
                .AppendLine()
                .AppendLine("1) Push an item to the Stack.")
                .AppendLine("2) Pop an item from the Stack.")
                .AppendLine("3) Clear the Stack.")
                .AppendLine("0) Exit")
                .Append('=', 50)
                .AppendLine();
            string? exercise1Choice = null;
            do
            {
                if(exercise1Choice == "0")
                {
                    break;
                }
                Console.WriteLine(exercise1Menu);
                Console.Write("Please make a choice: ");
                exercise1Choice = Console.ReadLine();

                switch(exercise1Choice)
                {
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Goodbye!");
                        break;
                    case "1":
                        Console.Clear();
                        try
                        {
                            Console.WriteLine("What would you like to push to the stack?");
                            string? exercise1PushValue = Console.ReadLine();
                            exercise1Stack.Push(exercise1PushValue);
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Push : Invalid Operation");
                        }
                        break;
                    case "2":
                        Console.Clear();
                        try
                        {
                            exercise1Stack.Pop();
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Pop : Invalid Operation");
                        }
                        break;
                    case "3":
                        Console.Clear();
                        exercise1Stack.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            } while (exercise1Choice != "0");
        }
    }
}

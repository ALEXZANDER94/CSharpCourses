using System.Reflection.PortableExecutable;
using System.Threading.Channels;

namespace ArraysAndListsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1) 
             * When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
                If no one likes your post, it doesn't display anything.
                If only one person likes your post, it displays: [Friend's Name] likes your post.
                If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
                If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
             *  Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
             *  Depending on the number of names provided, display a message based on the above pattern.
            */
            var names = new List<string?>();
            while (true)
            {
                Console.WriteLine("Enter a friend's name: ");
                names.Add(Console.ReadLine());
                if(names.Last() == null || names.Last() == "")
                {
                    break;
                }
            }
            // remove last index of names
            names.RemoveAt((names.Count-1));
            if(names.Count > 0)
            {
                if(names.Count == 1)
                {
                    Console.Write(names[0] + " likes your post");
                }
                else if(names.Count == 2)
                {
                    Console.Write(names[0] + " and " + names[1] + " like your post");
                }
                else
                {
                    Console.Write(names[0] + ", " + names[1] + ", and " + (names.Count - 2) + " others like your post");
                }
            }

            Console.WriteLine();

            // 2) Write a program and ask the user to enter their name.
            // Use an array to reverse the name and then store the result in a new string.
            // Display the reversed name on the console.

            string? exercise2Name = "";
            while(exercise2Name == "")
            {
                Console.Write("Enter your name: ");
                exercise2Name = Console.ReadLine();
            }
            char[] exercise2NameAsArray = exercise2Name.ToCharArray();
            foreach(char character in exercise2NameAsArray.Reverse())
            {
                Console.Write(character);
            }

            Console.WriteLine();

            // 3) Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try.
            // Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
            var exercise3NumberList = new List<int>();
            int exercise3EnteredNumber;
            while(exercise3NumberList.Count < 5)
            {
                Console.Write("Enter a number: ");
                exercise3EnteredNumber = Convert.ToInt32(Console.ReadLine());
                if(exercise3NumberList.IndexOf(exercise3EnteredNumber) != -1)
                {
                    Console.WriteLine("Enter a number you haven't entered before!");
                }
                else
                {
                    exercise3NumberList.Add(exercise3EnteredNumber);
                }
            }

            exercise3NumberList.Sort();
            foreach(int number in exercise3NumberList)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            // 4) Write a program and ask the user to continuously enter a number or type "Quit" to exit.
            // The list of numbers may include duplicates. Display the unique numbers that the user has entered.
            var exercise4NumberList = new List<int>();
            string? exercise4EnteredNumber = "";
            while (true)
            {
                Console.Write("Enter any number or 'Quit' to exit: ");
                exercise4EnteredNumber = Console.ReadLine();
                
                if (exercise4EnteredNumber == "Quit")
                {
                    break;
                }
                if(exercise4NumberList.IndexOf(Convert.ToInt32(exercise4EnteredNumber)) == -1)
                {
                    exercise4NumberList.Add(Convert.ToInt32(exercise4EnteredNumber));
                }
            }
            if(exercise4NumberList.Count > 0)
            {
                Console.WriteLine("Here's a list of unique numbers you've entered");
                foreach(int number in exercise4NumberList)
                {
                    Console.Write(number + " ");
                }
            }

            Console.WriteLine();

            // 5) Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
            // If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
            string? exercise5Numbers = "";
            var exercise5NumberListAsStrings = new List<string>();
            var exercise5NumbersList = new List<int>();
            while (true)
            {
                exercise5NumberListAsStrings.Clear();
                Console.Write("Enter a Comma Separated list of numbers: ");
                exercise5Numbers = Console.ReadLine();
                if(exercise5Numbers != "")
                {
                    exercise5NumberListAsStrings.AddRange(exercise5Numbers.Split(","));
                    if(exercise5NumberListAsStrings.Count < 5)
                    {
                        Console.WriteLine("Invalid List! Retry");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid List! Retry");
                }
            }
            //remove duplicates from list
            exercise5NumberListAsStrings = exercise5NumberListAsStrings.Distinct().ToList();
            foreach(string numberAsString in exercise5NumberListAsStrings)
            {
                exercise5NumbersList.Add(Convert.ToInt32(numberAsString));
            }
            exercise5NumbersList.Sort();
            exercise5NumbersList.RemoveRange(3, (exercise5NumbersList.Count - 3));
            Console.Write("The 3 smallest numbers are: ");
            foreach(int number in exercise5NumbersList)
            {
                Console.Write(number + " ");
            }
        }
    }
}
using System.Globalization;

namespace StringsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Write a program and ask the user to enter a few numbers separated by a hyphen.
            // Work out if the numbers are consecutive.
            // For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
            while(true)
            {
                Console.WriteLine("Enter a series of numbers separated by hyphen:");
                string? exercise1Input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(exercise1Input))
                {
                    string[] exercise1ListAsString = exercise1Input.Split('-');
                    
                    var exercise1List = new List<int>();
                    foreach (string numberAsString in exercise1ListAsString)
                    {
                        exercise1List.Add(Convert.ToInt32(numberAsString));
                    }
                    bool valid = true;
                    bool increasing = (exercise1List[0] < exercise1List[1]);
                    
                    for (int i = 0; i < (exercise1List.Count-1); i++)
                    {
                        int number1 = exercise1List[i];
                        int number2 = exercise1List[i+1];
                        // difference is greater than 1
                        if (Math.Abs(number1 - number2) != 1)
                        {
                            valid = false;
                            break;
                        }
                        
                        if( (increasing && number1 > number2) || (!increasing && number1 < number2) )
                        {
                            valid = false;
                            break;
                        }
                    }
                    Console.WriteLine(valid ? "Your list is consecutive" : "Your list is not consecutive");
                    break;
                }
            }

            Console.WriteLine();

            // 2) Write a program and ask the user to enter a few numbers separated by a hyphen.
            // If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates.
            // If so, display "Duplicate" on the console.
            Console.WriteLine("Enter another series of number separated by hyphen:");
            string? exercise2Input = Console.ReadLine();
            if(String.IsNullOrWhiteSpace(exercise2Input))
            {
                return;
            }
            string[] exercise2ListAsString = exercise2Input.Split('-');
            var exercise2List = new List<int>();
            foreach(string numberAsString in exercise2ListAsString)
            {
                exercise2List.Add(Convert.ToInt32(numberAsString));
            }
            int inputLength = exercise2List.Count;
            var exercise2DistinctList = exercise2List.Distinct().ToList();
            if (inputLength > exercise2DistinctList.Count)
            {
                Console.WriteLine("Duplicate values found");
            }
            else
            {
                Console.WriteLine("No Duplicates Found");
            }

                Console.WriteLine();

            // 3) Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59.
            // If the time is valid, display "Ok"; otherwise, display "Invalid Time".
            // If the user doesn't provide any values, consider it as invalid time.
            Console.Write("Enter a time value in 24-hour format: ");
            string? exercise3Input = Console.ReadLine();
            if(!String.IsNullOrWhiteSpace(exercise3Input))
            {
                string[] timeSpanParts = exercise3Input.Split(":");
                if (timeSpanParts.Length > 1)
                {
                    int hours = Convert.ToInt32(timeSpanParts[0]);
                    int minutes = Convert.ToInt32(timeSpanParts[1]);
                    if((hours < 0 || hours > 23) || (minutes < 0 || minutes > 59))
                    {
                        Console.WriteLine("Invalid Time");
                    }
                    else
                    {
                        Console.WriteLine("Ok");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Time");
                }
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }

            Console.WriteLine();

            // 4) Write a program and ask the user to enter a few words separated by a space.
            // Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents".
            // Make sure that the program is not dependent on the input.
            // So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
            Console.Write("Enter a few words separated by whitespace: ");
            string? exercise4Input = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(exercise4Input))
            {
                string exercise4Parameter = "";
                foreach(string part in exercise4Input.Split(' '))
                {
                    string normalizedPart = part.Trim().ToLower();
                    exercise4Parameter += normalizedPart.Substring(0, 1).ToUpper() + normalizedPart.Substring(1);
                }
                Console.WriteLine("PascalParameter is: " + exercise4Parameter);
            }

            Console.WriteLine();

            // 5) Write a program and ask the user to enter an English word.
            // Count the number of vowels (a, e, o, u, i) in the word.
            // So, if the user enters "inadequate", the program should display 6 on the console.
            Console.Write("Enter an English word: ");
            string? exercise5Input = Console.ReadLine();
            int vowelCount = 0;
            if (!String.IsNullOrWhiteSpace(exercise5Input))
            {
                char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
                for (int i = 0; i < exercise5Input.Length; i++)
                {
                    vowelCount += (vowels.Contains(exercise5Input[i])) ? 1 : 0;
                }
            }
            Console.WriteLine("Vowel Count: " + vowelCount);
        }
    }
}
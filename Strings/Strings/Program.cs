using System;
namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // these are effectively the same
            string firstName = "Alex";
            String lastName = "Avila";
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            // these are effectively the same
            string fullName = firstName + " " + lastName;
            string myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);

            string[] names = new string[3] { "John", "Jack", "Mary" };
            string formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);

            string text = "Hi John\nLook into the following paths:\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);

            string multilineText = @"Hi John
Look into the following paths:
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(multilineText);
        }
    }
}
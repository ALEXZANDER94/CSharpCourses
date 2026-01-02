namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Alex Avila ";

            // Trim removes whitespace at beginning and end of the string
            Console.WriteLine("Trim: '{0}'", fullName.Trim());

            // ToUpper converts all characters in the string to uppercase
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            // IndexOf returns the index of the requested character in the string
            int index = fullName.IndexOf(' ');
            // Substring returns a substring of the entire string based on the index and count parameters
            string firstName = fullName.Substring(0, index);
            string lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            // Split splits a string by the passed character
            string[] names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

            // Replace replaces the first parameter with the second parameter in the string
            Console.WriteLine(fullName.Replace("Alex", "Alexzander"));
            
            // IsNullOrEmpty returns true/false depending on if the string is null or empty ("")
            if(String.IsNullOrEmpty(null))
            {
                Console.WriteLine("Invalid");
            }

            // IsNullOrWhiteSpace returns true/false depending on if the string is null, empty, or whitespace
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            // Convert string to integer
            string number = "25";
            // Convert.ToInt32 is more reliable because if the passed string is empty, it won't error out
            Convert.ToInt32(number);
            // int.Parse also works, but will throw an exception if the passed string is empty
            int.Parse(number);

            // Convert float/integer to string
            float price = 29.95f;
            price.ToString();
            // You can also pass a format specifier to format the converted string a particular way
            // "C" for currency will output "$29.95"
            // "C0" will truncate the decimal and round and output "$30"
            Console.WriteLine(price.ToString("C"));

        }
    }
}
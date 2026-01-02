using System.Text;
namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // StringBuilder methods can be chained together
            StringBuilder builder = new StringBuilder();

            // Append concats a string to the end of the string
            builder.Append('-', 10);
            // AppendLine concats a string as an entire line
            builder.AppendLine();
            builder.Append("Header");
            builder.Append('-', 10);

            // Replace swaps the characters in the built string with the passed
            builder.Replace('-', '+');

            // Remove removes characters from the builder with the start and count parameters
            builder.Remove(0, 10); // start at index 0 and remove 10 characters

            // Insert add the specified string at the passed index
            builder.Insert(0, new string('-', 10));

            // use [] to access indexes of the builder
            Console.WriteLine("First Index: " + builder[0]);

            Console.WriteLine();

            Console.WriteLine(builder);

            // StringBuilder methods can be chained together
            // so the above can be condensed to
            /*
             * builder
             * .Append('-', 10)
             * .AppendLine()
             * .Append("Header")
             * .Append('-', 10)
             * .Replace('-', '+')
             * .Remove(0, 10)
             * .Insert(0, new string '-', 10));
            */
        }
    }
}
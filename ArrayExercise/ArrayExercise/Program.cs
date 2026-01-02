namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 3, 7, 9, 2, 14, 6 };
           
            // Length - size of the array
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf - returns the position of an element in the array
            int index = Array.IndexOf(numbers, 9); // 2
            Console.WriteLine("Index of value 9: " + index);

            // Clear - empties an array of the specified indexes
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effects of Clear()");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Copy - copies the contents of the array to another
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effects of Copy()");
            foreach (int number in another)
            {
                Console.WriteLine(number);
            }

            // Sort - sorts the elements in an array
            Array.Sort(numbers);
            Console.WriteLine("Effects of Sort()");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Reverse - reverses an array
            Array.Reverse(numbers);
            Console.WriteLine("Effects of Reverse()");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
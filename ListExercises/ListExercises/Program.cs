namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            // IndexOf - returns the index of the value in the list
            Console.WriteLine();
            Console.WriteLine("Index Of 1: " + numbers.IndexOf(1));

            // LastIndexOf - returns the index of the value in the list starting from the end of the list
            Console.WriteLine("Last Index Of 1: " + numbers.LastIndexOf(1));

            // Count - returns the number of objects in the list
            Console.WriteLine("Count: " +numbers.Count);

            // Remove - removes the passed item from the list ( only one instance )
            numbers.Remove(1);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            // this is how to remove all instances of a value in a list
            // CANNOT do this with a foreach, the program will crash if you modify the collection as it's being iterated
            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            // Clear - removes all objects from the list
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}

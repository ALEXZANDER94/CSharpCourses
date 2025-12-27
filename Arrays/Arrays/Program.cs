namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine("numbers[0] : {0}", numbers[0]);
            Console.WriteLine("numbers[1] : {0}", numbers[1]);
            Console.WriteLine("numbers[2] : {0}", numbers[2]);

            bool[] flags = new bool[3];
            flags[0] = true;
            Console.WriteLine("flags[0] : {0}", flags[0]);
            Console.WriteLine("flags[0] : {0}", flags[1]);
            Console.WriteLine("flags[0] : {0}", flags[2]);

            string[] names = new string[3] { "Jack", "John", "Mary" };
        }
    }
}
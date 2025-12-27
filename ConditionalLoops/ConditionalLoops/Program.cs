namespace ConditionalLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loops
            for(int i = 1; i <= 10; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();

            for(int i = 10; i >= 1; i--)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i); 
                }
            }

            // foreach loops
            string name = "John Smith";
            //for(int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}
            foreach(char character in name)
            {
                Console.WriteLine(character);
            }

            int[] numbers = new int[] {1, 2, 3, 4};
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            // while loops
            // same as the first for loop
            int i = 0;
            while(i <= 10)
            {
                if( i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            // if you use a while true, you have to include `break` at some point otherwise you'll create an infinite loop
            while (true)
            {
                Console.Write("Type your name: ");
                string? input = Console.ReadLine();

                if(!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    //continue will take the loop back to the start, ignoring the `break` at the end
                    continue;
                }
                
                break;
            }
        }
    }
}
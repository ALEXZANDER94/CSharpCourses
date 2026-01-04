namespace ClassesExercise
{
    class Stopwatch
    {
        public bool Started { get; set; }
        public DateTime Time { get; private set; }

        public Stopwatch()
        {
            Started = false;
        }

        public void Start()
        {
            Console.Clear();
            if (Started)
            {
                Console.WriteLine("The stopwatch has already been started!");
                return;
            }
            Started = true;
            Time = DateTime.Now;
            Console.WriteLine("The stopwatch has been started");
        }

        public void Stop()
        {
            Console.Clear();
            if(!Started)
            {
                Console.WriteLine("You must start the stopwatch first!");
                return;
            }

            ShowTime();
            Started = false;
        }

        public void ShowTime()
        {
            Console.Clear();
            if(!Started)
            {
                Console.WriteLine("The Time is: 00:00:00");
                return;
            }

            var CurrentTime = DateTime.Now;
            Console.WriteLine(string.Format("The stopwatch time is: {0}", CurrentTime - Time));
        }
    }

}

namespace Classes
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is {0}", (FirstName + " " + LastName));
        }
    }
}
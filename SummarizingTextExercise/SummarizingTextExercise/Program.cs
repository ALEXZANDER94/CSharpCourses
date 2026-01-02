
namespace SummarizingTextExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "This is going to be a really really really really really really long text.";
            string summary = StringUtility.SummarizeText(sentence, 25);
            Console.WriteLine(summary);
        }
    }
}
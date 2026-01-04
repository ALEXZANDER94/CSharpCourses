using System.Text;

namespace ClassesExercise
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime Posted { get; set; }

        public int Upvotes { get; set; }
        public int Downvotes { get; set; }

        public Post() {
            Title = "This is a StackOverflow post";
            Description = "This post discusses the complexities of classes within C#";
            Posted = DateTime.Now;
            Random random = new Random();
            Upvotes = random.Next(0, 100);
            Downvotes = random.Next(0, 100);
        }


        public void Upvote()
        {
            Console.Clear();
            Upvotes += 1;
            Console.WriteLine("The Post has been upvoted");
        }


        public void Downvote()
        {
            Console.Clear();
            Downvotes += 1;
            Console.WriteLine("The Post has been downvoted");
        }


        public void Summary()
        {
            Console.Clear();
            StringBuilder post = new StringBuilder();
            post
                .AppendLine(string.Format("Title: {0}", Title))
                .Append('-', 35)
                .AppendLine()
                .AppendLine(string.Format("Description: {0}", Description))
                .AppendLine(string.Format("Posted: {0}", Posted.ToString()))
                .AppendLine(string.Format("Upvotes: {0} | Downvotes: {1}", Upvotes, Downvotes))
                .Append('-', 35)
                .AppendLine();
            Console.WriteLine(post);
        }

    }
}

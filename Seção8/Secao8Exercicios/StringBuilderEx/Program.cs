using StringBuilderEx.Entities;

namespace StringBuilderEx;

class Program
{
    static void Main(string[] args)
    {

        Comment comment1 = new Comment("Have a nice trip");
        Comment comment2 = new Comment("Wow, thats awesome");
        Post post1 = new Post(
            DateTime.Parse("21/06/2017 14:02:44"),
            "Traveling to New Zealand",
            "I'm going to visit this wonderful country", 13
        );
        post1.addComment(comment1);
        post1.addComment(comment2);
        Comment comment3 = new Comment("Good night");
        Comment comment4 = new Comment("May the Force be with you");
        Post post2 = new Post(
            DateTime.Parse("28/07/2018 23:14:19"),
            "Good night guys",
            "See you tomorrow", 5
        );
        post2.addComment(comment3);
        post2.addComment(comment4);

        System.Console.WriteLine(post1);
        System.Console.WriteLine(post2);
    }
}

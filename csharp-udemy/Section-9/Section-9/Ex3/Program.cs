using System;
using System.Collections.Generic;
using Ex3.Entities;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Post> posts = new List<Post>();
            List<Comment> comments = new List<Comment>();

            Comment comment = new Comment("Have a nice trip");
            comments.Add(comment);

            comment = new Comment("Wow that's awesome!");
            comments.Add(comment);

            Post post = new Post
            (
                DateTime.Parse("06/21/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12,
                comments
            );
            posts.Add(post);

            comments = new List<Comment>();
            comment = new Comment("Good night");
            comments.Add(comment);

            comment = new Comment("May the Force be with you");
            comments.Add(comment);

            post = new Post(
                DateTime.Parse("07/28/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5,
                comments
            );
            posts.Add(post);

            foreach(Post x in posts)
            {
                Console.WriteLine(x);
            }
        }
    }
}

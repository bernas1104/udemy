using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3.Entities
{
    public class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; }

        public Post(DateTime moment, string title, string content, int likes, 
            List<Comment> comments)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;

            Comments = new List<Comment>();
            foreach(Comment x in comments)
            {
                Comments.Add(x);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.Append(Likes.ToString());
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString());
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach(Comment x in Comments)
            {
                sb.AppendLine(x.ToString());
            }

            return sb.ToString();
        }
    }
}

using System;
namespace Ex3.Entities
{
    public class Comment
    {
        public string Text { get; set; }

        public Comment(string text)
        {
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}

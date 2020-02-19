using System;
using System.Text;

namespace Ex4.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }

        public Client(string name, string email, DateTime date)
        {
            Name = name;
            Email = email;
            Date = date;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Client: " + Name + " (" + Date + ") - " + Email);

            return sb.ToString();
        }
    }
}

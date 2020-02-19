using System;
using System.Text;

namespace Ex4.Entities
{
    public class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name + ", $" + Price + ", ");

            return sb.ToString();
        }
    }
}

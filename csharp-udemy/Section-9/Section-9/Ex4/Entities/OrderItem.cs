using System;
using System.Text;

namespace Ex4.Entities
{
    public class OrderItem
    {
        public Product product { get; private set; }
        public int Quantity { get; private set; }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            this.product = product;
        }

        public double SubTotal()
        {
            return product.Price * Quantity;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(product.ToString() + "Quantity: " + Quantity.ToString()
                + ", Subtotal: $" + SubTotal().ToString("F2"));

            return sb.ToString();
        }
    }
}

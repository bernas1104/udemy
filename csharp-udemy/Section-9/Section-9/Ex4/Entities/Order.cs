using System;
using System.Collections.Generic;
using System.Text;
using Ex4.Entities.Enums;

namespace Ex4.Entities
{
    public class Order
    {
        public DateTime Date { get; private set; }
        public OrderStatus Status { get; private set; }
        public Client client { get; private set; }
        public List<OrderItem> items { get; private set; }

        public Order(OrderStatus status, Client client, 
            List<OrderItem> items)
        {
            Date = DateTime.Now;
            Status = status;
            this.client = client;

            this.items = new List<OrderItem>();
            this.items = items;
        }

        public void AddItem(OrderItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            items.Remove(item);
        }

        public double Total()
        {
            double total = 0.00;

            foreach(OrderItem x in items)
            {
                total += x.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Order moment: " + Date);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine(client.ToString());
            sb.AppendLine("Order items:");

            foreach(OrderItem x in items)
            {
                sb.AppendLine(x.ToString());
            }

            return sb.ToString();
        }
    }
}

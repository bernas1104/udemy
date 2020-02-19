using System;
using System.Collections.Generic;
using System.Text;
using Ex1.Entities.Enums;

namespace Ex1.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public Order()
        {
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}

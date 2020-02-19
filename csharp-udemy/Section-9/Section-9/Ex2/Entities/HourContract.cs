using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2.Entities
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract(DateTime date, double vph, int hours)
        {
            Date = date;
            ValuePerHour = vph;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}

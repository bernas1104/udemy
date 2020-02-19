using System;
using System.Collections.Generic;
using System.Text;
using Ex2.Entities.Enums;

namespace Ex2.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Dept { get; set; }
        public List<HourContract> Contracts { get; set; }

        public Worker(string name, WorkerLevel level, double baseSalary, Department dept)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Dept = dept;
            Contracts = new List<HourContract>();
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            HourContract rmv = null;
            rmv = Contracts.Find(x => x == contract);

            if(rmv != null)
            {
                Contracts.Remove(rmv);
            }
        }

        public double Income(int year, int month)
        {
            double TotalIncome = BaseSalary;

            foreach(HourContract x in Contracts)
            {
                if (x.Date.Year == year && x.Date.Month == month)
                {
                    TotalIncome += x.TotalValue();
                }
            }

            return TotalIncome;
        }

        public override string ToString()
        {
            return "Name: "
                + Name + "\n"
                + "Department: "
                + Dept;
        }
    }
}

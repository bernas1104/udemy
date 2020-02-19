using System;
namespace Ex2.Entities
{
    public class Department
    {
        public string Name { get; set; }

        public Department(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

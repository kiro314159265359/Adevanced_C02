using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    internal class Employee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary{ get; set; }
        public int Age{ get; set; }

        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;
            Employee E = (Employee)obj;
            return this.Age.CompareTo(E.Age);
        }

        public override string ToString()
        {
            return $"ID: {Id} , Name: {Name} , Salary: {Salary} , Age: {Age}";
        }
    }
}

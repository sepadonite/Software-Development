using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Employee
    {
        public Employee(string name)
        {
            Name = name;
        }

        string Name
        {
            get; set;
        }

        public override string ToString()
        {
            return $"Employee's name is {Name}";
        }
    }
}

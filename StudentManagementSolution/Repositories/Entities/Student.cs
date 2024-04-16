using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Student : Human
    {
        public double GPA { get; set; }

        public override string ToString() => $"Student: {Id} | {Name} | {Dob} | { GPA }";
    }
}

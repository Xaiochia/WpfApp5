using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    internal class Student
    {
        public String StudentId { get; set; }
        public String StudentName { get; set; }
        public override string ToString()
        {
            return $"{StudentId} - {StudentName}";
        }
    }
}

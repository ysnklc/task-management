using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Entity
{
   public class EmployeeTasks
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int TaskId { get; set; }
        public Tasks Tasks { get; set; }
    }
}

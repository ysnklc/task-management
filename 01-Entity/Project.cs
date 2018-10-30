using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Entity
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}

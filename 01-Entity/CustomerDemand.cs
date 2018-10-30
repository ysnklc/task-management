using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Entity
{
    public class CustomerDemand
    {
        public int CustomerDemandId { get; set; }
        public string Request { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Entity
{
    public class Tasks
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime FinishDate { get; set; }

        public int StateId { get; set; }
        public State State { get; set; }

        public int ProjetId { get; set; }
        public Project Project { get; set; }

     
     

    }
}

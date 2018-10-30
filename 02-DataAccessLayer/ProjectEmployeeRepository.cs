using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Entity;

namespace _02_DataAccessLayer
{
   public class ProjectEmployeeRepository:BaseRepository<ProjectEmployee>
    {
        private TaskManagerContext _context;
        public ProjectEmployeeRepository(TaskManagerContext context) : base(context)
        {
            _context = context;
        }
    }
}

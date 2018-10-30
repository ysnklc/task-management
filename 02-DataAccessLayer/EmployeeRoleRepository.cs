using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Entity;

namespace _02_DataAccessLayer
{
    public  class EmployeeRoleRepository: BaseRepository<EmployeeRole>
    {
        private TaskManagerContext _context;
        public EmployeeRoleRepository(TaskManagerContext context) : base(context)
        {
            _context = context;
        }
    }
}

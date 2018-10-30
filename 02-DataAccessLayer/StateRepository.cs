using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Entity;

namespace _02_DataAccessLayer
{
    public  class StateRepository : BaseRepository<State>
    {
        private TaskManagerContext _context;
        public StateRepository(TaskManagerContext context) : base(context)
        {
            _context = context;
        }
    }
}

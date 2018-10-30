using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Entity;

namespace _02_DataAccessLayer
{
    public class TasksRepository : BaseRepository<Tasks>
    {
        private TaskManagerContext _context;
        public TasksRepository(TaskManagerContext context) : base(context)
        {
            _context = context;
        }
        //public List<Tasks> GetTasksByEmployee(int id)
        //{
        //    return _context.Taskes.Where(x => x. == id).ToList();
        //}
        //public List<Tasks> GetTasksByProject(int id)
        //{
        //    return _context.Taskes.Where(x => x.ProjetId == id).ToList();
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Entity;

namespace _02_DataAccessLayer
{
   public class EmployeeRepository :BaseRepository<Employee>
   {
       private TaskManagerContext _context;
        public EmployeeRepository(TaskManagerContext context) : base(context)
        {
            _context = context;
        }


        public Employee GetEmployeeLogin(string mail, string password)
        {
            Employee e=new Employee();
             _context.Employees.FirstOrDefault(x => x.Mail == mail);
            if (e!=null)
            {
                return e;
            }
            else
            {
                return null;
            }
        }
    
    }
}

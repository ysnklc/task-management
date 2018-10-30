using _01_Entity;
using _02_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BusinessLogicLayer
{
    public class EmployeeTasksBusiness
    {
        UnitOfWork _uof;
        public EmployeeTasksBusiness()
        {
            _uof = new UnitOfWork();
        }
        

        public List<EmployeeTasks> GetAll()
        {
            return _uof.EmployeeTasksRepository.GetAll();
        }
        public bool Add(EmployeeTasks item)
        {
            if (item.EmployeeId!=0&&item.TaskId!=0)
            {
                _uof.EmployeeTasksRepository.Add(item);


                return _uof.ApplyChange();
            }
            return false;
        }
    }
}

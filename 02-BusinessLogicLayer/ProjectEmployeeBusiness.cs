using _01_Entity;
using _02_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BusinessLogicLayer
{
    public class ProjectEmployeeBusiness
    {
        UnitOfWork _uof;
        public ProjectEmployeeBusiness()
        {
            _uof = new UnitOfWork();
        }
        

        public List<ProjectEmployee> GetAll()
        {
            return _uof.ProjectEmployeeRepository.GetAll();
        }


        public bool Add(ProjectEmployee item)
        {
            if (item.EmployeeId != 0 && item.ProjectId != 0)
            {
                _uof.ProjectEmployeeRepository.Add(item);


                return _uof.ApplyChange();
            }
            return false;
        }
    }
}

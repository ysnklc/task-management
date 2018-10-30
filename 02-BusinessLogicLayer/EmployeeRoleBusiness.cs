using _01_Entity;
using _02_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BusinessLogicLayer
{
    public class EmployeeRoleBusiness
    {
        UnitOfWork _uof;
        public EmployeeRoleBusiness()
        {
            _uof = new UnitOfWork();
        }
        public bool Add(EmployeeRole item)
        {
            if (!string.IsNullOrWhiteSpace(item.RoleName))
            {
                _uof.EmployeeRoleRepository.Add(item);
                return _uof.ApplyChange();
            }
            return false;
        }

        public bool Delete(EmployeeRole item)
        {
            if (item != null)
            {
                _uof.EmployeeRoleRepository.Delete(item);
                return _uof.ApplyChange();
            }
            return false;
        }

        public bool Update(EmployeeRole item)
        {
            if (!string.IsNullOrWhiteSpace(item.RoleName))
            {
                _uof.EmployeeRoleRepository.Update(item);
                return _uof.ApplyChange();
            }
            return false;
        }

        public EmployeeRole Get(int id)
        {
            return _uof.EmployeeRoleRepository.Get(id);
        }

        public List<EmployeeRole> GetAll()
        {
            return _uof.EmployeeRoleRepository.GetAll();
        }
    }
}

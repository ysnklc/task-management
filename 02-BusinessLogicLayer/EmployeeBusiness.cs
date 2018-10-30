using _01_Entity;
using _02_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BusinessLogicLayer
{
    public class EmployeeBusiness
    {
        UnitOfWork _uof;
        public EmployeeBusiness()
        {
            _uof = new UnitOfWork();
        }
        // todo esra burayı tamamla

        public bool Add(Employee item)
        {
            if (!string.IsNullOrWhiteSpace(item.FirstName))
            {
                _uof.EmployeeRepository.Add(item);
                return _uof.ApplyChange();
            }
            return false;
        }

        public bool Delete(Employee item)
        {
            if (item != null)
            {
                _uof.EmployeeRepository.Delete(item);
                return _uof.ApplyChange();
            }
            return false;
        }

        public bool Update(Employee item)
        {
            if (!string.IsNullOrWhiteSpace(item.FirstName))
            {
                _uof.EmployeeRepository.Update(item);
                return _uof.ApplyChange();
            }
            return false;
        }

        public Employee Get(int id)
        {
            return _uof.EmployeeRepository.Get(id);
        }

        public List<Employee> GetAll()
        {
            return _uof.EmployeeRepository.GetAll();
        }
       
        public Employee GetEmployeeLogin(string mail, string password)
        {
            if (string.IsNullOrWhiteSpace(mail) && string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Lütfen bilgileri doğru  giriniz");
            }

            var result = (from emp in _uof.EmployeeRepository.GetAll()
                          where emp.Mail == mail && emp.Password == password
                          select emp ).ToList();

            if (result == null)
            {
                throw new Exception("Böyle kullanıcı bulunamadı ");
            }
            else
            {
                return result.FirstOrDefault();
            }

        }

       

        
    }
}

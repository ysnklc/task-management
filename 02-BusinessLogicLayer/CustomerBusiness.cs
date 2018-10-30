using _01_Entity;
using _02_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02_BusinessLogicLayer
{
    public class CustomerBusiness
    {
        UnitOfWork _uof;
        public CustomerBusiness()
        {
            _uof = new UnitOfWork();
        }
        public bool Add(Customer item)
        {
            if (!string.IsNullOrWhiteSpace(item.CustomerName))
            {
                _uof.CustomerRepository.Add(item);
                return _uof.ApplyChange();
            }
            return false;
        }
        public bool Delete(Customer item)
        {
            if (item != null)
            {
                _uof.CustomerRepository.Delete(item);
               
                return _uof.ApplyChange();
            }
            return false;
        }
        public bool Update(Customer item)
        {
            if (!string.IsNullOrWhiteSpace(item.CustomerName))
            {
                _uof.CustomerRepository.Update(item);
                return _uof.ApplyChange();
            }
            return false;
        }

        public Customer Get(int id)
        {
            return _uof.CustomerRepository.Get(id);
        }

        public List<Customer> GetAll()
        {
            return _uof.CustomerRepository.GetAll();
        }
        

    }
}

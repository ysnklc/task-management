using _01_Entity;
using _02_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BusinessLogicLayer
{
    class CustomerDemandBusiness
    {
        UnitOfWork _uof;
        public CustomerDemandBusiness()
        {
            _uof = new UnitOfWork();
        }

        public bool Add(CustomerDemand item)
        {
            if (!string.IsNullOrWhiteSpace(item.Request))
            {
                _uof.CustomerDemandRepository.Add(item);
                return _uof.ApplyChange();
            }
            return false;
        }

        public bool Delete(CustomerDemand item)
        {
            if (item != null)
            {
                _uof.CustomerDemandRepository.Delete(item);
                return _uof.ApplyChange();
            }
            return false;
        }

        public bool Update(CustomerDemand item)
        {
            if (!string.IsNullOrWhiteSpace(item.Request))
            {
                _uof.CustomerDemandRepository.Update(item);
                return _uof.ApplyChange();
            }
            return false;
        }

        public CustomerDemand Get(int id)
        {
            return _uof.CustomerDemandRepository.Get(id);
        }

        public List<CustomerDemand> GetAll()
        {
            return _uof.CustomerDemandRepository.GetAll();
        }
    }
}

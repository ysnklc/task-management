using _01_Entity;
using _02_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BusinessLogicLayer
{
    public class StateBusiness
    {
        UnitOfWork _uof;
        public StateBusiness()
        {
            _uof = new UnitOfWork();
        }

        public bool Add(State item)
        {
            if (!string.IsNullOrWhiteSpace(item.Status))
            {
                _uof.StateRepository.Add(item);
                return _uof.ApplyChange();
            }
            return false;
        }

        public bool Delete(State item)
        {
            if (item != null)
            {
                _uof.StateRepository.Delete(item);
                return _uof.ApplyChange();
            }
            return false;
        }

        public bool Update(State item)
        {
            if (!string.IsNullOrWhiteSpace(item.Status))
            {
                _uof.StateRepository.Update(item);
                return _uof.ApplyChange();
            }
            return false;
        }

        public State Get(int id)
        {
            return _uof.StateRepository.Get(id);
        }

        public List<State> GetAll()
        {
            return _uof.StateRepository.GetAll();
        }
    }
}

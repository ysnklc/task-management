using _01_Entity;
using _02_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BusinessLogicLayer
{
    public class TasksBusiness
    {
        UnitOfWork _uof;
        Tasks _task;
        public TasksBusiness()
        {
            _uof = new UnitOfWork();
            _task = new Tasks();
        }

        public bool Add(Tasks item)
        {
            if (!string.IsNullOrWhiteSpace(item.TaskName))
            {
                _uof.TasksRepository.Add(item);
                return _uof.ApplyChange();
            }
            return false;
        }

        public bool Delete(Tasks item)
        {
            if (item != null)
            {
                _uof.TasksRepository.Delete(item);
                return _uof.ApplyChange();
            }
            return false;
        }

        public bool Update(Tasks item)
        {
            if (!string.IsNullOrWhiteSpace(item.TaskName))
            {
                _uof.TasksRepository.Update(item);
                return _uof.ApplyChange();
            }
            return false;
        }

        public Tasks Get(int id)
        {
            return _uof.TasksRepository.Get(id);
        }

        public List<Tasks> GetAll()
        {
            return _uof.TasksRepository.GetAll();
        }


        public List<Tasks> GetAllByProject(int id)
        {
            List<Tasks> result = (from t in GetAll()
                                  where t.ProjetId == id 
                                  select t).ToList();
            
            return result;

            
        }
        public List<Tasks> GetTaskState(int id ,int state)
        {
            List<Tasks> result = (from t in GetAll()
                                  where t.ProjetId == id  && t.StateId==state
                                  select t).ToList();

            return result;


        }


    }
}

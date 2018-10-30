using _01_Entity;
using _02_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BusinessLogicLayer
{
  public   class ProjectBusiness
    {
        UnitOfWork _uof;
        public ProjectBusiness()
        {
            _uof = new UnitOfWork();

        }


        public bool Add(Project item)
        {
            if (!string.IsNullOrWhiteSpace(item.ProjectName))
            {
                _uof.ProjectRepository.Add(item);
                return _uof.ApplyChange();
            }
            return false;
        }

        public bool Delete(Project item)
        {
            if (item != null)
            {
                _uof.ProjectRepository.Delete(item);

                return _uof.ApplyChange();
            }
            return false;
        }
        public bool Update(Project item)
        {
            if (!string.IsNullOrWhiteSpace(item.ProjectName))
            {
                _uof.ProjectRepository.Update(item);
                return _uof.ApplyChange();
            }
            return false;
        }

        public Project Get(int id)
        {
            return _uof.ProjectRepository.Get(id);
        }

        public List<Project> GetAll()
        {
            return _uof.ProjectRepository.GetAll();
        }
    }
}

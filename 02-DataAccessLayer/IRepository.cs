using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DataAccessLayer
{
   public  interface IRepository<T>
    {
        
        void Add(T item);
        void Delete(T item);
        void Update(T item);
        T Get(int id);
        List<T> GetAll();

    }
}

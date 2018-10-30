using System;
using System.Collections.Generic;
using System.Linq;


namespace _02_DataAccessLayer
{
     
  public   abstract class BaseRepository<TEntity>:IRepository<TEntity> where TEntity:class 
    {
          TaskManagerContext _context;

       public BaseRepository(TaskManagerContext context)
       {
           _context = context;
       }

       public void Add(TEntity item)
       {
           _context.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Added;
       }

       public void Delete(TEntity item)
       {
           _context.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Deleted;
        
       }

       public void Update(TEntity item)
       {
           _context.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Modified;
       }

       public TEntity Get(int id)
       {
           return _context.Set<TEntity>().Find(id);

       }

       public List<TEntity> GetAll()
       {
           return _context.Set<TEntity>().ToList();
       }


    }
}

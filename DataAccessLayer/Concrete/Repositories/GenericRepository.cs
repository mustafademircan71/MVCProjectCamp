using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T>
        where T : class
    {
        Context ctx = new Context();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = ctx.Set<T>();
        }

        public void Delete(T entity)
        {
            var deletedEntity = ctx.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            //_object.Remove(entity);
            ctx.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

       public void Insert(T entity)
        {
            var addedEntity = ctx.Entry(entity);
            addedEntity.State = EntityState.Added;
            //_object.Add(entity);
            ctx.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T entity)
        {
            var updateEntity = ctx.Entry(entity);
            updateEntity.State = EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}

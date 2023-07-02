using DAL;
using MVCProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly StorageManagementContext dbContext;
        public GenericRepository(StorageManagementContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool Add(T entity)
        {
            try
            {
                dbContext.Set<T>().Add(entity);
                return dbContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                dbContext.Set<T>().Remove(entity);
                return dbContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>();
        }

        public T GetById(int id)
        {
            return dbContext.Set<T>().Find(id);
        }

        public T? GetFirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return dbContext.Set<T>().FirstOrDefault(predicate);
        }

        public IEnumerable<T> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return dbContext.Set<T>().Where(predicate);
        }

        public bool Update(T entity)
        {
            try
            {
                dbContext.Set<T>().Update(entity);
                return dbContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}

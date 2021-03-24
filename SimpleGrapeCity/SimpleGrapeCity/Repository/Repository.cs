using Microsoft.EntityFrameworkCore;
using SimpleGrapeCity.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SimpleGrapeCity.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _db;
        internal DbSet<T> dbSet;
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetFirstOrDefalt(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}

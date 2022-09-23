using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Generic_Repository
{
    public  abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContext _applicationDbContext;
        public GenericRepository(DbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public virtual void Add(T entity)
        {
            _applicationDbContext.Set<T>().Add(entity);
           
        }

        public void Get(T entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IGenericRepository<T>.getAll()
        {
            return _applicationDbContext.Set<T>().ToList();
        }
    }
}

using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Linq;
using System.Linq.Dynamic.Core;


namespace Infrastructure.Generic_Repository
{
    public  abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContext _applicationDbContext;
        private readonly DbSet<T> _dbset;
        public GenericRepository(DbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            _dbset = _applicationDbContext.Set<T>();
        }
        public virtual void Add(T entity)
        {
            _dbset.Add(entity);
           
        }

        public virtual (List<T> item, int total, int totalDisplay) GetAll(Expression<Func<T, bool>>? filter = null, 
                         string? orderBy = null, string includeProperties = "", int pageIndex = 1, 
                                    int pageSize = 10, bool isTrackingOff = false)
        {
            IQueryable<T> values = _dbset;

            int total = values.Count();
            int totalDisplay = values.Count();

            if(filter!=null)
            {
                values=values.Where(filter);
                totalDisplay = values.Count();
            }
            
            foreach (var includeproperty in includeProperties.Split(new char[] {','},
                                                StringSplitOptions.RemoveEmptyEntries))
            {
                values=values.Include(includeproperty);
            }
            if (orderBy != null)
            {
                var result = values.OrderBy(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize);
                if (isTrackingOff)
                    return (result.AsNoTracking().ToList(), total, totalDisplay);
                else
                    return (result.ToList(), total, totalDisplay);
            }
            else
            {
                var result = values.Skip((pageIndex - 1) * pageSize).Take(pageSize);
                if (isTrackingOff)
                    return (result.AsNoTracking().ToList(), total, totalDisplay);
                else
                    return (result.ToList(), total, totalDisplay);
            }
        }

        
    }
}

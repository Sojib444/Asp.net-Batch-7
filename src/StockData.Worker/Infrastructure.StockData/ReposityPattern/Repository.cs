using Infrastructure.StockData.ORM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.StockData.ReposityPattern
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> _dbset { get; set; }
        public Repository(DbContext dbset)
        {
            _dbset = dbset.Set<T>();
        }
        public virtual void Add(T Entity)
        {
            _dbset.Add(Entity);
        }
    }
}

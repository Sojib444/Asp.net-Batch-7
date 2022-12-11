using Infrastructure.StockData.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.StockData.UnifOfWork
{
    public class ApplicationUniofWork : IApplicationUnitofWork
    {
        public ApplicationUniofWork(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public ApplicationDbContext DbContext { get; }

        public void Dispose()
        {
            DbContext.Dispose();
        }

        public void Save()
        {
           DbContext.SaveChanges();
        }
    }
}

using Infrastructure.StockData.ORM;
using Serilog;
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
            try
            {
                DbContext.SaveChanges();
            }
            catch(Exception ex)
            {
                Log.Write(Serilog.Events.LogEventLevel.Verbose, ex.Message);
            }
        }
    }
}

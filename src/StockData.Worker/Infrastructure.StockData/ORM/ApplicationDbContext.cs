using Infrastructure.StockData.Entiies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.StockData.ORM
{
    public class ApplicationDbContext:DbContext,IApplicationDbContext
    {
        private  string ConnectionString { get; set; }
        private  string AssemblyName { get; set; }
        public ApplicationDbContext(string conncetionstring, string assemblyname)
        {
            ConnectionString = conncetionstring;
            AssemblyName = assemblyname;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString, e =>
                {
                    e.MigrationsAssembly(AssemblyName);
                });
            }
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<StockPrice> StockPrices { get; set; }
    }
}

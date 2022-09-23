using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityFramework
{
    public class ApplicationDbContext:DbContext,IApplicationDbContex
    {
        private readonly string _connectionstring;
        private readonly string _assembly;
        public ApplicationDbContext( string connectionstring,string assembly)
        {
            _connectionstring = connectionstring;
            _assembly = assembly;

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionstring,
                    c => c.MigrationsAssembly(_assembly));
            }
            base.OnConfiguring(optionsBuilder);


        }

       public DbSet<Book>? books { get; set; }
       public DbSet<Reader>? readers { get; set; }
    }
}

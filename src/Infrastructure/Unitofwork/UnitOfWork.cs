using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Unitofwork
{
    public abstract class UnitOfWork : IUnitofWork
    {
        private readonly DbContext _context;
        public UnitOfWork(DbContext context)
        {
            _context = context;
        }
        public virtual void Dispose()
        {
            _context?.Dispose();
        }

        public  virtual void Save()
        {
            _context?.SaveChanges();
        }
    }
}

using Infrastructure.Entities;
using Infrastructure.EntityFramework;
using Infrastructure.Generic_Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityRepository
{
    public class ReaderRepository:GenericRepository<Reader>,IReaderRepository
    {
        public ReaderRepository(IApplicationDbContex context) : base((DbContext)context)
        {

        }
    }
}

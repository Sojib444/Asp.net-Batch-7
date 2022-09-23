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
    public class BookRepository: GenericRepository<Book>,IBookRepository
    {
        public BookRepository(IApplicationDbContex context) : base((DbContext)context)
        {

        }
    }
}

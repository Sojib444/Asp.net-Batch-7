using Infrastructure.EntityFramework;
using Infrastructure.EntityRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Unitofwork
{
    public class ApplicationUnitofWork :UnitOfWork, IApplicationUnitofWork
    {



        public IBookRepository bookRepository { get; }

        public IReaderRepository readerRepository { get; }

        public ApplicationUnitofWork(IApplicationDbContex dbContext,
           IBookRepository brepo, IReaderRepository rrepo) : base((DbContext)dbContext)
        {
            bookRepository = brepo;
            readerRepository = rrepo;
        }


    }
}

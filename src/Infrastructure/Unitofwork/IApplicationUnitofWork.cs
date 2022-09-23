using Infrastructure.EntityRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Unitofwork
{
    public interface IApplicationUnitofWork:IUnitofWork
    {
        IBookRepository bookRepository { get;  }
        IReaderRepository readerRepository { get;  }

    }
}

using Infrastructure.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public interface IBookService
    {
        public void CreateBook( BBook book);
    }
}

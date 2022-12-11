using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.StockData.ReposityPattern
{
    public interface IRepository<T> where T:class
    {
        public void Add(T Entity);
    }
}

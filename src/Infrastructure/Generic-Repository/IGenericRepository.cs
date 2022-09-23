using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Generic_Repository
{
    public interface IGenericRepository<T>
    {
        void Add(T entity);
        IEnumerable<T> getAll();
        void Get(T entity);
    }
}

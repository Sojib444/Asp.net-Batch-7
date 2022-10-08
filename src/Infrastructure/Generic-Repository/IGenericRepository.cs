using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Generic_Repository
{
    public interface IGenericRepository<T>
    {
        void Add(T entity);
        (List<T> item,int total,int totalDisplay) GetAll(Expression<Func<T,bool>>? filter=null,
                          string orderBy = null,string includeProperties = "", int pageIndex = 1, 
                          int pageSize = 10, bool isTrackingOff = false); 
    }
}

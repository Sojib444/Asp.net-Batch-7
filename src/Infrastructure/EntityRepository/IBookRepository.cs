using Infrastructure.Entities;
using Infrastructure.Generic_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityRepository
{
    public interface IBookRepository:IGenericRepository<Book>
    {
        (IList<Book> data, int total, int totalDisplay) GetCourses(int pageIndex,
            int pageSize, string searchText, string orderby);
    }
}

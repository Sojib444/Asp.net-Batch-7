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

        public (IList<Book> data, int total, int totalDisplay) GetCourses(int pageIndex,
             int pageSize, string searchText, string orderby)
        {
            (IList<Book> data, int total, int totalDisplay) results =
                GetAll(x => x.Writer.Contains(searchText), orderby,
                "", pageIndex, pageSize, true);

            return results;
        }
    }
}

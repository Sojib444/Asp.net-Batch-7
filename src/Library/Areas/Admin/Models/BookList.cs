using Autofac;
using Infrastructure.Service;
using Library.Models;

namespace Library.Areas.Admin.Models
{
    public class BookList:BaseModel
    {

        public IBookService _bookservice;
        public BookList(IBookService bookservice)
        {
            _bookservice = bookservice;
        }
        public override void ResolveDependency(ILifetimeScope scope)
        {
            base.ResolveDependency(scope);
            _bookservice = _scope.Resolve<IBookService>();
        }


        public object? GetJson(DataTableAjaxModel ajaxmodel)
        {
            var data=_bookservice.GetBook(
                ajaxmodel.PageIndex,
                ajaxmodel.PageSize,
                ajaxmodel.SearchText,
                ajaxmodel.GetSortText(new string[] { "ID","Name", "Writer", "Price" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.book select new string[]
                {
                    record.Name,
                    record.Writer,
                    record.Price.ToString(),
                    record.Id.ToString(),
                }).ToArray()
            };
        }
    }
}

using Autofac;
using Infrastructure.BusinessObject;
using Infrastructure.Service;
using System.ComponentModel.DataAnnotations;

namespace Library.Areas.Admin.Models
{
    public class Book
    {
        private IBookService _bookservice;
        private ILifetimeScope _scope;
        public Book()
        {
        }

        public Book(IBookService studentService)
        {
            _bookservice = studentService;
        }

        internal void ResolveDependency(ILifetimeScope scope)
        {
            _scope = scope;
            _bookservice = _scope.Resolve<IBookService>();
        }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Writer { get; set; }
        [Required]
        public int Price { get; set; }

        public async Task CreateStudent()
        {
            BBook book = new BBook();
            book.Name = Name;
            book.Writer = Writer;
            book.Price = Price;

            _bookservice.CreateBook(book);
        }
    }
}

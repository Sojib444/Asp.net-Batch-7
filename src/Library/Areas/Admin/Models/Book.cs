using Autofac;
using Infrastructure.BusinessObject;
using Infrastructure.Service;
using Library.Models;
using System.ComponentModel.DataAnnotations;

namespace Library.Areas.Admin.Models
{
    public class Book:BaseModel
    {
        private IBookService _bookservice;
        public Book()
        {
        }

        public Book(IBookService studentService)
        {
            _bookservice = studentService;
        }
        public override void ResolveDependency(ILifetimeScope scope)
        {
            base.ResolveDependency(scope);
           _bookservice =_scope.Resolve<IBookService>();
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

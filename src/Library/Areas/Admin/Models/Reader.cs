using Autofac;
using Infrastructure.BusinessObject;
using Infrastructure.Service;
using Library.Models;
using Microsoft.Build.Framework;

namespace Library.Areas.Admin.Models
{
    public class Reader:BaseModel
    {
        private IReaderService _studentService;
        public Reader()
        {
        }

        public Reader(IReaderService studentService)
        {
            _studentService = studentService;
        }

        public override void ResolveDependency(ILifetimeScope scope)
        {
            base.ResolveDependency(scope);
           _studentService= _scope.Resolve<IReaderService>();
        }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public async Task CreateReader()
        {
            BReader reader = new BReader();
            reader.Name = Name;
            reader.Address = Address;

            _studentService.CreateReader(reader);
        }
    }
}

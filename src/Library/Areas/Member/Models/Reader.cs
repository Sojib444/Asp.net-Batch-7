using Autofac;
using Infrastructure.BusinessObject;
using Infrastructure.Service;
using Microsoft.Build.Framework;

namespace Library.Areas.Member.Models
{
    public class Reader
    {
        private IReaderService _studentService;
        private ILifetimeScope _scope;
        public Reader()
        {
        }

        public Reader(IReaderService studentService)
        {
            _studentService = studentService;
        }

        internal void ResolveDependency(ILifetimeScope scope)
        {
            _scope = scope;
            _studentService = _scope.Resolve<IReaderService>();
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

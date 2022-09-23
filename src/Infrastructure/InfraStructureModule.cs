using Autofac;
using Infrastructure.EntityFramework;
using Infrastructure.EntityRepository;
using Infrastructure.Service;
using Infrastructure.Unitofwork;

namespace Infrastructure
{
    public class InfraStructureModule:Module
    {
        private readonly string _connectionstring;
        private readonly string _assembly;
        public InfraStructureModule(string connectionstring, string assembly)
        {
            _connectionstring = connectionstring;
            _assembly = assembly;

        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDbContext>().AsSelf()
                .WithParameter("connectionstring", _connectionstring)
                .WithParameter("assembly", _assembly)
                .InstancePerLifetimeScope();

            builder.RegisterType<ApplicationDbContext>().As<IApplicationDbContex>()
                .WithParameter("connectionstring", _connectionstring)
                .WithParameter("assembly", _assembly)
                .InstancePerLifetimeScope();

            builder.RegisterType<BookService>().As<IBookService>()
            .InstancePerLifetimeScope();

            builder.RegisterType<BookRepository>().As<IBookRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ReaderService>().As<IReaderService>()
                 .InstancePerLifetimeScope();

            builder.RegisterType<ReaderRepository>().As<IReaderRepository>()
                .InstancePerLifetimeScope();


            builder.RegisterType<ApplicationUnitofWork>().As<IApplicationUnitofWork>()
               .InstancePerLifetimeScope();


            base.Load(builder);
        }
    }
}

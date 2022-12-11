using Autofac;
using Infrastructure.StockData.ORM;
using Infrastructure.StockData.ReposityPattern;
using Infrastructure.StockData.UnifOfWork;

namespace Infrastructure.StockData
{
    public class InfrastructureModule:Module
    {
        private string ConnectionString { get; set; }
        private string AssemblyName { get; set; }
        public InfrastructureModule(string conncetionstring,string assemblyname)
        {
            ConnectionString = conncetionstring;
            AssemblyName = assemblyname;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDbContext>().As<IApplicationDbContext>()
                .WithParameter("conncetionstring", ConnectionString)
                .WithParameter("assemblyname", AssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<ApplicationDbContext>().AsSelf()
                .WithParameter("conncetionstring", ConnectionString)
                .WithParameter("assemblyname", AssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<ApplicationUniofWork>().As<IApplicationUnitofWork>()
                .InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
